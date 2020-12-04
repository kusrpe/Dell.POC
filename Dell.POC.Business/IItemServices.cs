using System;
using System.Collections.Generic;
using System.Text;
using Dell.POC.Repository;
using Dell.POC.Models;
using System.Threading.Tasks;

namespace Dell.POC.Services
{
    public interface  IItemServices<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        
    }
}
