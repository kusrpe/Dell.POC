using System;
using System.Collections.Generic;

#nullable disable

namespace Dell.POC.Models
{
    public partial class EntityItemGroup
    {
        public int EntityItemGroupId { get; set; }
        public int EntityId { get; set; }
        public int ItemGroupId { get; set; }

        public virtual Entity Entity { get; set; }
        public virtual ItemGroup ItemGroup { get; set; }
    }
}
