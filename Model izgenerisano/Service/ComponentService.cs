/***********************************************************************
 * Module:  Sastojak.cs
 * Author:  Nikola
 * Purpose: Definition of the Class Sastojak
 ***********************************************************************/

using System;

namespace Service
{
   public class ComponentService
   {
      public List<Component> GetAll()
      {
         
         return null;
      }
      
      public void Save(Model.Component newComponent)
      {
         
      }
      
      public Boolean Delete(String componentName)
      {
         
         return null;
      }
      
      public void SortByName()
      {
         
      }
      
      public void SortByQuantityInMedicine()
      {
         
      }
      
      public List<Component> SearchByName(String name)
      {
         
         return null;
      }
      
      public List<Component> SearchyDescription(String description)
      {
         
         return null;
      }
      
      public List<Component> SearchByMedicine()
      {
         
         return null;
      }
   
      public Repository.ComponentRepository componentRepository;
   
   }
}