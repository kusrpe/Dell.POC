using Dell.POC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dell.POC.Repository.Interfaces;
using Dell.POC.Repository.Impl;
namespace Dell.POC.Services
{
    public class EntityService<T> : IEntitiyService<Entity>
    {
        private readonly IEntityRepository<Entity> _entityRepository;
        
        public EntityService(
           IEntityRepository<Entity> entityRepository
          )
        {
            _entityRepository = entityRepository;
            
        }
        public Task<IEnumerable<Entity>> GetAllAsync()
        {
            Task<IEnumerable<Entity>> output = _entityRepository.GetAllAsync();
            return output;
        }
        public Task InsertAsync(Entity entity)
        {
            return _entityRepository.InsertAsync(entity);
        }
        public IEnumerable<Entity> GetAll()
        {

            var output = _entityRepository.GetAll();
            IEnumerable<Entity> retsult = output;
            return output;
        }

    }
}
