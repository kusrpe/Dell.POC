using System;
using System.Collections.Generic;
using System.Text;

namespace Dell.POC.Models
{
 
    public class IA
    {
        public int Attribute_Item_Id { get; set; }
        public int Item_Id { get; set; }
        public string Item_Attribute_Value { get; set; }
    }

    public class I
    {
        public int Item_Id { get; set; }
        public string Item_Name { get; set; }
        public string Item_Description { get; set; }
        public List<IA> IA { get; set; }
    }

    public class IGI
    {
        public int Item_Group_Item_Id { get; set; }
        public int Item_Id { get; set; }
        public int Item_Group_Id { get; set; }
        public List<I> I { get; set; }
    }

    public class IGA
    {
        public int Attribute_Item_Id { get; set; }
        public int Item_Group_Id { get; set; }
        public string Item_Group_Attribute { get; set; }
        public List<IGI> IGI { get; set; }
    }

    public class Ig
    {
        public int Item_Group_Id { get; set; }
        public string Item_Group_Name { get; set; }
        public string Item_Group_Description { get; set; }
        public List<IGA> IGA { get; set; }
    }

    public class Eig
    {
        public int Entity_Item_Group_Id { get; set; }
        public int Entity_Id { get; set; }
        public int Item_Group_Id { get; set; }
        public List<Ig> ig { get; set; }
    }

    public class Ea
    {
        public int Entity_Attribute_Id { get; set; }
        public int Entity_Id { get; set; }
        public string Attribute_Value { get; set; }
        public List<Eig> eig { get; set; }
    }

    public class Root
    {
        public int Entity_Id { get; set; }
        public string Entity_Name { get; set; }
        public string Entity_Description { get; set; }
        public List<Ea> ea { get; set; }
    }


}
