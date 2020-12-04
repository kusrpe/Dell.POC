using System;
using System.Collections.Generic;

#nullable disable

namespace Dell.POC.Models
{
    public partial class ItemGroupItem
    {
        public int ItemGroupItemId { get; set; }
        public int ItemId { get; set; }
        public int ItemGroupId { get; set; }

        public virtual Item Item { get; set; }
        public virtual ItemGroup ItemGroup { get; set; }
    }
}
