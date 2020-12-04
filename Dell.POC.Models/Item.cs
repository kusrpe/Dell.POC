using System;
using System.Collections.Generic;
using Newtonsoft.Json;
#nullable disable

namespace Dell.POC.Models
{
    public partial class Item
    {
        public Item()
        {
            ItemAttributes = new HashSet<ItemAttribute>();
            ItemGroupItems = new HashSet<ItemGroupItem>();
        }
        [JsonIgnore]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        [JsonIgnore]
        public virtual ICollection<ItemAttribute> ItemAttributes { get; set; }
        [JsonIgnore]
        public virtual ICollection<ItemGroupItem> ItemGroupItems { get; set; }
    }
}
