using System;
using System.Collections.Generic;

#nullable disable

namespace Dell.POC.Models
{
    public partial class Entity
    {
        public Entity()
        {
            EntityItemGroups = new HashSet<EntityItemGroup>();
        }

        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public string EntityDescription { get; set; }

        public virtual ICollection<EntityItemGroup> EntityItemGroups { get; set; }
    }
}
