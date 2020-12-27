using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Dell.POC.Models;
using Dell.POC.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Dell.POC.ConfigurationSettings;
using Dapper;
using System.ComponentModel;
using System.Text;

namespace Dell.POC.Repository.Impl
{
    /// <inheritdoc/>
    public abstract class GenericRepository<T> :IGenericRepository<T>  where T:class
    {
        private readonly string _tableName;

        protected GenericRepository()
        {
            
        }
        /// <summary>
        /// Generate new connection based on connection string
        /// </summary>
        /// <returns></returns>
        private SqlConnection SqlConnection()
        {
            return new SqlConnection(@"Server=LAPTOP-L3MAKAHN\SQLEXPRESS;Database=DellPOC;Trusted_Connection=True;");
        }

        /// <summary>
        /// Open new connection and return it for use
        /// </summary>
        /// <returns></returns>
        protected IDbConnection CreateConnection()
        {
            var conn = SqlConnection();
          
            return conn;
        }

        public virtual async Task<IEnumerable<dynamic>> GetAllAsync(string query)
        {
            using (var connection = CreateConnection())
            {
                dynamic res = await connection.QueryAsync<T>(query, commandType: CommandType.Text);
                return  res;
            }
           
        }

        public Task DeleteRowAsync(string query)
        {
            throw new NotImplementedException();
        }

        public string GetAsync(string query)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(string query)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                var res = await connection.QueryAsync(query, commandType: CommandType.Text);
                return true;
            }
        }

        public async Task<bool>  InsertAsync(string query)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                var res = await connection.QueryAsync(query, commandType: CommandType.Text);
                return true ;
            }
           
        }
    }
}