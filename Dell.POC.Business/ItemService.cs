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
    public class ItemService : IItemService
    {

        private readonly IEntityRepository entityRepository;
        public ItemService(
           IEntityRepository entityRepository
          )
        {
            this.entityRepository = entityRepository;

        }
        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return null;
          
        }

        public async Task<ResultVM> Insert(string itemName, string itemDescription)
        {
            ResultVM resultVM = null;
            string query = string.Format(@"insert into Item(Item_Name,Item_Description) values('{0}','{1}')", itemName, itemDescription);
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
