using System;
using System.Collections.Generic;

#nullable disable

namespace Dell.POC.Models
{
    public partial class ItemGroupAttribute
    {
        public int AttributeItemId { get; set; }
        public int ItemGroupId { get; set; }
        public string ItemGroupAttribute1 { get; set; }

        public virtual ItemGroup ItemGroup { get; set; }
    }
}
