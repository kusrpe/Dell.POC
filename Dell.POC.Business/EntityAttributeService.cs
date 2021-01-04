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
    public class EntityAttributeService : IEntitiyAttributeService
    {

        private readonly IEntityRepository entityRepository;
        public EntityAttributeService(
           IEntityRepository entityRepository
          )
        {
            this.entityRepository = entityRepository;

        }
        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return null;
          
        }

        public async Task<ResultVM> Insert(int entityId, string attributeValue, string attributeName)
        {
            ResultVM resultVM = null;
            string query = string.Format(@"insert into Entity_Attribute(Entity_Id,Attribute_Value,Attribute_Name) values('{0}','{1}','{2}')", entityId, attributeValue, attributeName);
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
                    Message = "Insertion Failed.",
                };
             
            }
            return resultVM;

        }

     
    }
}
