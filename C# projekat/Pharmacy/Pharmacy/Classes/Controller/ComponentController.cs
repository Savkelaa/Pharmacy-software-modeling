

using System;
using System.Collections.Generic;
using Model;
using Service;

namespace Controller
{
   public class ComponentController
   {
        ComponentService componentService = new ComponentService();
        public List<Model.Component> GetAll()
      {
            return componentService.GetAll();
      }
     
   
   
   }
}