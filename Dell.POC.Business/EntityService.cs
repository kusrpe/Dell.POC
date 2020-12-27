using Dell.POC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dell.POC.Repository.Interfaces;
using Dell.POC.Repository.Impl;
using SqlMapper;
using System.Linq;
namespace Dell.POC.Services
{
    public class EntityService : IEntitiyService
    {

        private readonly IEntityRepository entityRepository;
        public EntityService(
           IEntityRepository entityRepository
          )
        {
            this.entityRepository = entityRepository;

        }
        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            string query = @"
                          SELECT E.ENTITY_ID AS 'ENTITYID', ENTITY_NAME  AS 'ENTITYNAME',
                            EA.ENTITY_ATTRIBUTE_ID AS 'ENTITYATTRIBUTEID', EA.ATTRIBUTE_NAME AS 'ATTRIBUTENAME',
                            EA.ATTRIBUTE_VALUE  AS 'ATTRIBUTEVALUE',
                            IG.ITEM_GROUP_ID AS 'ITEMGROUPID',
                            IG.ITEM_GROUP_DESCRIPTION AS 'ITEMGROUPDESCRIPTION',
                            IG.ITEM_GROUP_NAME AS 'ITEMGROUPNAME'
							,I.ITEM_ID AS 'ITEMID',
							I.ITEM_NAME AS 'ITEMNAME',
							I.ITEM_DESCRIPTION AS 'ITEMDESCRIPTION'
							,IGA.ATTRIBUTE_ITEM_ID	AS 'ITEMGROUPATTRIBUTEID' ,
							IGA.ITEM_GROUP_ATTRIBUTE AS 'ITEMGROUPATTRIBUTEVALUE',
							IGA.ITEM_GROUP_ATTRIBUTE_NAME AS 'ITEMGROUPATTRIBUTENAME'
                             FROM ENTITY E
                            INNER JOIN ENTITY_ATTRIBUTE EA ON EA.ENTITY_ID = E.ENTITY_ID
                            INNER JOIN ENTITY_ITEM_GROUP EIG ON EIG.ENTITY_ID = E.ENTITY_ID
                            INNER JOIN ITEM_GROUP IG ON IG.ITEM_GROUP_ID = EIG.ITEM_GROUP_ID
							INNER JOIN ITEM_GROUP_ITEM IGI ON IGI.ITEM_GROUP_ID = IG.ITEM_GROUP_ID
							INNER JOIN  ITEM I ON I.ITEM_ID = IGI.ITEM_GROUP_ITEM_ID
							INNER JOIN ITEM_GROUP_ATTRIBUTE IGA ON IGA.ITEM_GROUP_ID = IG.ITEM_GROUP_ID";
            var output = await entityRepository.GetAllAsync(query);
            return (IEnumerable<Entity>)output;
          
        }

        public async Task<ResultVM> Insert(string entityName, string entityDesc)
        {
            ResultVM resultVM = null;
            string query = string.Format(@"insert into entity(Entity_Name,Entity_Description) values('{0}','{1}')", entityName,entityDesc);
            bool output = await entityRepository.InsertAsync(query);
            if ( output)
            {
                 resultVM = new ResultVM
                {
                    Message = "Sucessfully Inserted.",
                };
                
            }
            else
            {
                resultVM = new ResultVM
                {
                    Message = "Sucessfully Inserted.",
                };
             
            }
            return resultVM;

        }

        public async Task<ResultVM> Update(int EntityId, string entityName, string entityDesc)
        {
            ResultVM resultVM = null;
            string query = string.Format(@"update  entity set ", entityName, entityDesc);
            bool output = await entityRepository.InsertAsync(query);
            if (output)
            {
                resultVM = new ResultVM
                {
                    Message = "Sucessfully Inserted.",
                };

            }
            else
            {
                resultVM = new ResultVM
                {
                    Message = "Sucessfully Inserted.",
                };

            }
            return resultVM;
        }
    }
}
