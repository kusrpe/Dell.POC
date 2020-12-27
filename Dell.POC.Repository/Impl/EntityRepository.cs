using System;
using System.Collections.Generic;
using System.Text;
using Dell.POC.Repository.Interfaces;
using Dell.POC.Models;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Linq;
namespace Dell.POC.Repository.Impl
{
    public class EntityRepository : GenericRepository<Entity>, IEntityRepository
    {

        public EntityRepository() : base()
        {

        }

        public override async Task<IEnumerable<dynamic>> GetAllAsync(string query)
        {
            using (var connection = CreateConnection())
            {
                var output = new Dictionary<int, Entity>();
                Entity entityType;
                var result = await connection.QueryAsync<Entity>(query,

                     new[]
                     {
                        typeof(Entity),
                        typeof(EntityAttribute),
                        typeof(ItemGroup),
                        typeof(Item),
                        typeof(ItemGroupAttribute),
                     },

                     obj =>
                     {
                         Entity entity = (obj[0] as Entity);
                         EntityAttribute entityAttribute = obj[1] as EntityAttribute;
                         ItemGroup itemGroup = obj[2] as ItemGroup;
                         Item item = obj[3] as Item;
                         ItemGroupAttribute itemGroupAttribute = obj[4] as ItemGroupAttribute;

                         if (!output.TryGetValue(entity.EntityId, out entityType))
                         {
                             output.Add(entity.EntityId, entityType = entity);
                         }

                         if (entityType.EntityAttributes == null)
                         {
                             entityType.EntityAttributes = new List<EntityAttribute>();
                         }

                         if (entityAttribute != null)
                         {
                             if (!entityType.EntityAttributes.Any(x => x.EntityAttributeId == entityAttribute.EntityAttributeId))
                             {
                                 entityType.EntityAttributes.Add(entityAttribute);
                             }
                         }

                         if (itemGroup != null)
                         {
                             if (!entityType.ItemGroups.Any(x => x.ItemGroupId == itemGroup.ItemGroupId))
                             {
                                 if (itemGroup.Items == null)
                                 {
                                     itemGroup.Items = new List<Item>();
                                 }
                                 itemGroup.Items.Add(item);

                                 if (itemGroup.ItemGroupAttribute == null)
                                 {
                                     itemGroup.ItemGroupAttribute = new List<ItemGroupAttribute>();
                                 }
                                 itemGroup.ItemGroupAttribute.Add(itemGroupAttribute);
                                 entityType.ItemGroups.Add(itemGroup);
                             }
                         }
                         return entityType;
                     },

                    splitOn: "EntityId,EntityAttributeId,ItemGroupId,ItemId,ItemGroupAttributeId");
                List<Entity> Entities = new List<Entity>();
                Entities = result.Distinct().ToList();
                return Entities.AsEnumerable();
            }


        }



    }
}
