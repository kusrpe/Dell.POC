using System;
using System.Collections.Generic;

#nullable disable

namespace Dell.POC.Models
{
    public partial class EntityAttribute
    {
        public int EntityAttributeId { get; set; }
        public int EntityId { get; set; }
        public string AttributeValue { get; set; }

        public virtual Entity Entity { get; set; }
    }
}
