/***********************************************************************
 * Module:  Lek.cs
 * Author:  Nikola
 * Purpose: Definition of the Class Lek
 ***********************************************************************/

using System;

namespace Model
{
   public class Medicine
   {
      public String Id;
      public String Name;
      public String Manufacturer;
      public float Price;
      public int Quantity;
      public Dictionary<Component, String> Components;
      public bool Accepted = false;
      public bool Deleted = false;
      
      public System.Collections.ArrayList component;
      
      
      public System.Collections.ArrayList GetComponent()
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
   
   }
}