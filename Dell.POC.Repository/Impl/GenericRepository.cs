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
    public abstract class GenericRepository :IGenericRepository
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
        private IDbConnection CreateConnection()
        {
            var conn = SqlConnection();
            //conn.Open();
            return conn;
        }

        public string GetAllAsync(string query)
        {
            using (var connection = CreateConnection())
            {

                var res = connection.ExecuteScalar<string>(query, commandType: CommandType.Text);
                return res;
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

        public Task UpdateAsync(string query)
        {
            throw new NotImplementedException();
        }

        public  Task InsertAsync(string query)
        {
            using (var connection = CreateConnection())
            {
                connection.Open();
                var res = connection.QueryAsync(query, commandType: CommandType.Text);
                return  res;
            }
        }
    }
}