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
        string GetAllAsync();

        Task<ResultVM> Insert(string entityName,string entityDesc);
       
    }
}
