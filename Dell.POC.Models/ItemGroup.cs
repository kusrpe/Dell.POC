using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
#nullable disable

namespace Dell.POC.Models
{
    public  class ItemGroup
    {
      public ItemGroup()
        {
        
        }

        public int ItemGroupId { get; set; }
        public string ItemGroupName { get; set; }
        public string ItemGroupDescription { get; set; }

        public List<Item> Items { get; set; }
       
    
        public List<ItemGroupAttribute> ItemGroupAttribute { get; set; }
      
    }
}
