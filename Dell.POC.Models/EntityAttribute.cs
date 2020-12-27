using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Dell.POC.Models
{
    public  class EntityAttribute
    {
        public int EntityAttributeId { get; set; }
        [JsonIgnore]
        public int EntityId { get; set; }
        public string AttributeValue { get; set; }

        public string AttributeName { get; set; }
       
    }
}
