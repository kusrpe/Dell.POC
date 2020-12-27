using System;
using System.Collections.Generic;
using Newtonsoft.Json;
#nullable disable

namespace Dell.POC.Models
{
    public  class Item
    {
        public Item()
        {
           
            
        }
        
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }

    
       
    }
}
