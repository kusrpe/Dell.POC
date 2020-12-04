using Dell.POC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dell.POC.Repository.Interfaces;
using Dell.POC.Repository.Impl;
namespace Dell.POC.Services
{
    public class ItemService <T>: IItemServices<T>
    {
        private readonly IItemRepository _iItemRepository;
        
        public ItemService(
           IItemRepository iItemRepository
          )
        {
            _iItemRepository = iItemRepository;
            
        }
        public Task<IEnumerable<T>> GetAllAsync()
        {
            //Task<IEnumerable<Item>> output =  _iItemRepository.GetAllAsync();
            //return output;
            return null;
        }
        public Task InsertAsync(Item item)
        {
            return _iItemRepository.InsertAsync(item);
        }
    }
}
