using System;
using System.Collections.Generic;
using System.Text;
using Dell.POC.Repository;
using Dell.POC.Models;
using System.Threading.Tasks;

namespace Dell.POC.Services
{
    public interface  IEntitiyAttributeService
    {
      

        Task<ResultVM> Insert(int entityId, string attributeValue, string attributeName);

      

    }
}
