using System;
using System.Collections.Generic;
using System.Text;
using Dell.POC.Repository;
using Dell.POC.Models;
using System.Threading.Tasks;

namespace Dell.POC.Services
{
    public interface  IEntitiyService<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task InsertAsync(T entity);

        IEnumerable<T> GetAll();
    }
}
