

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class ComponentController
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
         
         return false;
      }
      
      public List<Component> SearchByName(String name)
      {
         
         return null;
      }
      
      public List<Component> SearchByDescription(String description)
      {
         
         return null;
      }
      
      public List<Component> SearchByMedicine()
      {
         
         return null;
      }
   
      public Service.ComponentService componentService;
   
   }
}