﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dell.POC.Models;
namespace Dell.POC.Repository.Interfaces

{
    /// <summary>
    /// Base repository to manage generic operations.
    /// </summary>
    /// <typeparam name="T">Any class type.</typeparam>
    public interface IGenericRepository
    {
        string GetAllAsync(string query);
        Task DeleteRowAsync(string query);
        string GetAsync(string query);
        
        Task UpdateAsync(string query);
        Task InsertAsync(string query);
      

    }
}
