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
        public User getByEmail(String email)
        {
            foreach (User u in GetAll())
            {
                if(u.Email==email)
                {
                    return u;
                }
            }
            return null;
        }
        public void SaveBill(List<User> korisnici)
        {
            patients = korisnici;
            writeInJson();
        }

//NAPRAVITI FUNKCIJU ZA UNOS DICIONARY JSON -- UPDATE OWNEDMEDICINECOUNT

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