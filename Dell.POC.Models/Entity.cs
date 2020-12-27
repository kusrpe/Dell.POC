using System;
using System.Collections.Generic;


#nullable disable

namespace Dell.POC.Models
{
    public  class Entity
    {
       
        public Entity()
        {
            ItemGroups = new List<ItemGroup>();
            EntityAttributes = new List<EntityAttribute>();
        }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
      
        public List<EntityAttribute> EntityAttributes { get; set; }

        public List<ItemGroup> ItemGroups { get; set; }
    }
}
