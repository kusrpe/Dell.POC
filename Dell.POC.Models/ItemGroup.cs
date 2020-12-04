using System;
using System.Collections.Generic;

#nullable disable

namespace Dell.POC.Models
{
    public partial class ItemGroup
    {
        public ItemGroup()
        {
            EntityItemGroups = new HashSet<EntityItemGroup>();
            ItemGroupAttributes = new HashSet<ItemGroupAttribute>();
            ItemGroupItems = new HashSet<ItemGroupItem>();
        }

        public int ItemGroupId { get; set; }
        public string ItemGroupName { get; set; }
        public string ItemGroupDescription { get; set; }

        public virtual ICollection<EntityItemGroup> EntityItemGroups { get; set; }
        public virtual ICollection<ItemGroupAttribute> ItemGroupAttributes { get; set; }
        public virtual ICollection<ItemGroupItem> ItemGroupItems { get; set; }
    }
}
