using System;
using System.Collections.Generic;
using System.Text;

namespace Dell.POC.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class EntityAttributeValue
    {
    }

    public class EntityAttribute
    {
        public string EntityAttributeName { get; set; }
        public int EntityAttributeId { get; set; }
        public EntityAttributeValue EntityAttributeValue { get; set; }
    }

    public class Item
    {
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemId { get; set; }
    }

    public class ItemGroupAttribute
    {
        public string ItemGroupAttributeName { get; set; }
        public string ItemGroupAttributeValue { get; set; }
        public int ItemGroupAttributeId { get; set; }
    }

    public class ItemGroup2
    {
        public List<object> ItemGroups { get; set; }
        public List<Item> Items { get; set; }
        public ItemGroupAttribute ItemGroupAttribute { get; set; }
        public string ItemGroupName { get; set; }
        public int ItemGroupId { get; set; }
        public string ItemGroupDescription { get; set; }
    }

    public class Item2
    {
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemId { get; set; }
    }

    public class ItemGroupAttribute2
    {
        public string ItemGroupAttributeName { get; set; }
        public string ItemGroupAttributeValue { get; set; }
        public int ItemGroupAttributeId { get; set; }
    }

    public class ItemGroup
    {
        public List<ItemGroup2> ItemGroups { get; set; }
        public List<Item2> Items { get; set; }
        public ItemGroupAttribute2 ItemGroupAttribute { get; set; }
        public string ItemGroupName { get; set; }
        public int ItemGroupId { get; set; }
        public string ItemGroupDescription { get; set; }
    }

    public class Entity
    {
        public string EntityName { get; set; }
        public int EntityId { get; set; }
        public EntityAttribute EntityAttribute { get; set; }
        public List<ItemGroup> ItemGroups { get; set; }
    }

    public class Root
    {
        public Entity Entity { get; set; }
    }


}
