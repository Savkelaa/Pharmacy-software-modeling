
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Service
{
   public class ComponentService
   {
        ComponentRepository componentRepository = new ComponentRepository();

      public List<Model.Component> GetAll()
      {
            return componentRepository.GetAll();
      }
      
      public void Save(Model.Component newComponent)
      {
         
      }
      
      public void Delete(String componentName)
      {
         
      }
   
   
   }
}