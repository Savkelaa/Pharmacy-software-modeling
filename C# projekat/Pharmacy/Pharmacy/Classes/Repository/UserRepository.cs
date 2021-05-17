using System;
using System;
using System.Collections.Generic;
using System.IO;
using Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;


namespace Repository
{
   public class UserRepository
   {
        private String path= "patients.json";
        public List<User> patients = new List<User>();

        public UserRepository()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    patients = JsonConvert.DeserializeObject<List<User>>(json);
                }
            }
        }

        //public void SaveAll(ObservableCollection<User> users)
        //{
        //    JsonSerializer serializer = new JsonSerializer();
        //    serializer.Formatting = Formatting.Indented;
        //    StreamWriter writer = new StreamWriter("patients.json");
        //    JsonWriter jWriter = new JsonTextWriter(writer);
        //    serializer.Serialize(jWriter, users);
        //    jWriter.Close();
        //    writer.Close();
        //}


        public void writeInJson()
        {
            String json = JsonConvert.SerializeObject(patients, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public void Save(User newPatient)
      {
            patients.Add(newPatient);
            writeInJson();
        }
      
      public List<User> GetAll()
      {
            return patients;
       }
      
      public List<Medicine> GetNumberOfOwned(int patientId)
      {
         
         return null;
      }
      
      public List<Medicine> GetNumberOfWeekOwned(int patientId)
      {
         
         return null;
      }
   
      
   
   }
}