using Dell.POC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dell.POC.Repository.Interfaces;
using Dell.POC.Repository.Impl;
namespace Dell.POC.Services
{
    public class EntityService : IEntitiyService
    {
        private readonly IEntityRepository _entityRepository;
        
        public EntityService(
           IEntityRepository entityRepository
          )
        {
            _entityRepository = entityRepository;
            
        }
        public string GetAllAsync()
        {
           string  query = @"select *  from entity e
                            inner join entity_attribute ea on e.entity_Id = ea.entity_Id
                            inner join Entity_Item_Group eig on eig.Entity_Id = e.Entity_Id
                            inner join Item_Group ig on ig.Item_Group_Id = eig.Item_Group_Id
                            inner join Item_Group_Attribute IGA on IGA.Item_Group_Id = ig.Item_Group_Id
                            inner join Item_Group_Item IGI on IGI.Item_group_Id = IGA.Item_group_Id
                            inner join Item I on I.Item_Id = igi.Item_Group_Item_Id
                            inner join Item_Attribute IA on IA.Item_Id = I.Item_Id
							for json auto";
            string output = _entityRepository.GetAllAsync(query);
            return output;
        }

        public async Task<ResultVM> Insert(string entityName, string entityDesc)
        {
            
            string query = string.Format(@"Insert into Entity select '{0}','{1}'", entityName, entityDesc);
            Task output = _entityRepository.InsertAsync(query);
            if ( output != null)
            {
                var resultVM = new ResultVM
                {
                    Message = "Entity Successfuly inserted",
                };
                return resultVM;
               

            }
            else
            {
                var resultVM = new ResultVM
                {
                    Message = "Entity insertion failed"
                };
                return resultVM;
            }
           
        }
    }
}
