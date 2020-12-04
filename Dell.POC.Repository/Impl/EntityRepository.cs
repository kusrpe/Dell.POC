using System;
using System.Collections.Generic;
using System.Text;
using Dell.POC.Repository.Interfaces;
using Dell.POC.Models;
namespace Dell.POC.Repository.Impl
{
    public class EntityRepository<T> : GenericRepository<Entity>,IEntityRepository<T>
    {
        public EntityRepository():base("Entity")
        {

        }
    }
}
