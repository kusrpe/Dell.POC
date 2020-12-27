using System;
using System.Collections.Generic;

#nullable disable

namespace Dell.POC.Models
{
    public  class ItemGroupItem
    {
        public int ItemGroupItemId { get; set; }
        public int ItemId { get; set; }
        public int ItemGroupId { get; set; }

        public  Item Item { get; set; }
        public  ItemGroup ItemGroup { get; set; }
    }
}
