
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Repository
{
   public class ComponentRepository
   {
        private String path = "components.json";
        public List<Model.Component> components = new List<Model.Component>();

        public ComponentRepository()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    components = JsonConvert.DeserializeObject<List<Model.Component>>(json);
                }
            }
        }

        public void writeInJson()
        {
            String json = JsonConvert.SerializeObject(components, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public List<Model.Component> GetAll()
      {
         return components;
      }
      
      public void Save(Model.Component newComponent)
      {
         
      }
      
      public void Delete(String componentName)
      {
         
      }
   
     
   
   }
}