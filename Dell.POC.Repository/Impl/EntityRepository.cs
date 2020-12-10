using System;
using System.Collections.Generic;
using System.Text;
using Dell.POC.Repository.Interfaces;
using Dell.POC.Models;
using System.Threading.Tasks;

namespace Dell.POC.Repository.Impl
{
    public class EntityRepository: GenericRepository,IEntityRepository
    {
       
        public EntityRepository():base()
        {
           
        }


        //public Task DeleteRowAsync(string query)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<string> GetAllAsync(string query)
        //{
        //    throw new NotImplementedException();
        //}

        //public string GetAsync(string query)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task InsertAsync(string query)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task UpdateAsync(string query)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
