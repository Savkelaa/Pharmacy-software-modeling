

using System;
using System.Collections.Generic;
using Model;

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
   
      public Service.ComponentService componentService;
   
   }
}