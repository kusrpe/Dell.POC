using System;
using System.Collections.Generic;
using System.Text;
using Dell.POC.Repository;
using Dell.POC.Models;
using System.Threading.Tasks;

namespace Dell.POC.Services
{
    public interface  IEntitiyService
    {
        Task<IEnumerable<Entity>> GetAllAsync();

        Task<ResultVM> Insert(string entityName,string entityDesc);

        Task<ResultVM> Update(int EntityId, string entityName, string entityDesc);

    }
}
