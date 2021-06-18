

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

     /*   public System.Collections.ArrayList GetComponent()
      {
         if (component == null)
            component = new System.Collections.ArrayList();
         return component;
      }
      
      
      public void SetComponent(System.Collections.ArrayList newComponent)
      {
         RemoveAllComponent();
         foreach (Component oComponent in newComponent)
            AddComponent(oComponent);
      }
      
      
      public void AddComponent(Component newComponent)
      {
         if (newComponent == null)
            return;
         if (this.component == null)
            this.component = new System.Collections.ArrayList();
         if (!this.component.Contains(newComponent))
            this.component.Add(newComponent);
      }
      
      
      public void RemoveComponent(Component oldComponent)
      {
         if (oldComponent == null)
            return;
         if (this.component != null)
            if (this.component.Contains(oldComponent))
               this.component.Remove(oldComponent);
      }
      
      
      public void RemoveAllComponent()
      {
         if (component != null)
            component.Clear();
      }
   */
   }
}