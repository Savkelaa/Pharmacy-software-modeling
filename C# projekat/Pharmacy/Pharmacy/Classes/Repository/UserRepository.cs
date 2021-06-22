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
        private String path= "users.json";
        public List<User> users = new List<User>();

        public UserRepository()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                   users = JsonConvert.DeserializeObject<List<User>>(json);
                }
            }
        }
        public User getByEmail(String email)
        {
            foreach (User u in users)
            {
                if(u.Email==email)
                {
                    return u;
                }
            }
            return null;
        }

        public void UpdateBill(List<User> u)
        {
            users = u;
            writeInJson();
        }


        public void UpdateOwnedMedicineCounter(Dictionary<String, int> MedicineOwned, String email)
        {
            int index = users.FindIndex(obj => obj.Email == email);
            users[index].OwnedMedicineCounter = MedicineOwned ;
            writeInJson();
        }


        public void writeInJson()
        {
            String json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public void Save(User newPatient)
        {            
            users.Add(newPatient);
            writeInJson();
        }
      
      public List<User> GetAll()
      {
            return users;
       }
      
     
   
      
   
   }
}