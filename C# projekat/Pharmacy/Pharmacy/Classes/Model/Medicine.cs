

using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
   public class Medicine
   {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Manufacturer { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public Dictionary<int, String> Components { get; set; }
        public bool Accepted { get; set; }
        public bool Deleted { get; set; }


        public Medicine()
        {

        }

        public Medicine(string id, string name, string manufacturer, float price, int quantity,  bool accepted, bool deleted, Dictionary<int,String> components)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Quantity = quantity;
            Components = components;
            Accepted = accepted;
            Deleted = deleted;
          
        }

  
   }
}