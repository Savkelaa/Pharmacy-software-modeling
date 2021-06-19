
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Service
{
   public class ComponentService
   {
        ComponentRepository componentRepository = new ComponentRepository();

      public List<Model.Component> GetAll()
      {
            return componentRepository.GetAll();
      }
   
   }
}