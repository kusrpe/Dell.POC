using System;
using System.Collections.Generic;

#nullable disable

namespace Dell.POC.Models
{
    public partial class ItemAttribute
    {
        public int AttributeItemId { get; set; }
        public int ItemId { get; set; }
        public string ItemAttributeValue { get; set; }

        public virtual Item Item { get; set; }
    }
}
