using System;
using System.Collections.Generic;

#nullable disable

namespace Dell.POC.Models
{
    public  class EntityItemGroup
    {
        public int EntityItemGroupId { get; set; }
        public int EntityId { get; set; }
        public int ItemGroupId { get; set; }

        public  Entity Entity { get; set; }
        public  List<ItemGroup> ItemGroup { get; set; }
    }
}
