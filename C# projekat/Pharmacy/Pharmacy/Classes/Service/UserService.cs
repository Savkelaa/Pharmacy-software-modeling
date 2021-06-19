using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using Model;
using Repository;

namespace Service
{
   public class UserService
   {

        UserRepository userRepository = new UserRepository();
      
        public void Save(User newPatient)
        {
            userRepository.Save(newPatient);
        }
      
      public List<User> GetAll()
      {
            List<User> allEmployees = new List<User>(userRepository.GetAll());
            List<User> patients = new List<User>();

            foreach(User u in allEmployees)
            {
                if(u.Type=="patient")
                {
                    patients.Add(u);
                }
             
            }

            return patients;

      }
      
      public User Registration(String email, String password)
      {
         List<User> users = userRepository.GetAll();

         foreach (User u in users)
            {
                if ((u.Email == email) && (u.Password == password))
                {  
                    return u;
                }        
            }
            return null;
      }
      
      public Boolean IsJmbgValid(String jmbg)
      {
            User patient = userRepository.GetAll().SingleOrDefault(s => (s.Jmbg.Equals(jmbg)));
            if (patient != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public Boolean IsEmailValid(String email)
        {
            User patient = userRepository.GetAll().SingleOrDefault(s => (s.Email.Equals(email)));
            if (patient != null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public Boolean CheckOwnedWeek(String email)
        {
            User user = new User();
            user = userRepository.getByEmail(email);
            int count = 0;
            DateTime sevenDays = DateTime.Today.AddDays(-7);

            foreach (Bill b in user.Bills)
            {
                if(b.DateTime>sevenDays)
                count+=b.MedicineAndQuantity.Count;   
            }

            if(count>50)
            {
                return false;
            }
            else
            { 
                return true;
            }
        }

        public void UpdateBill(User u, Bill bill)
        {
            List<User> users = userRepository.GetAll();
            foreach (User user in users)
            {
                if (user.Email == u.Email)
                {
                   user.Bills.Add(bill);
                }
            }
            userRepository.UpdateBill(users);
        }


        public Boolean CheckOwnedOne(String email, Dictionary<String, int> dictCart)
      {
            User user = new User();
            user = userRepository.getByEmail(email);

            foreach (KeyValuePair<String, int> countExisting in user.OwnedMedicineCounter)
            {
                foreach(KeyValuePair<String, int> countCart in dictCart)
                {
                    if(countExisting.Key==countCart.Key)
                    {
                        user.OwnedMedicineCounter[countExisting.Key] += dictCart[countCart.Key];
                    }
                    updateOwnedMedicineCounter(email);
                }   
            }
    
           foreach (KeyValuePair<String, int> countExisting in user.OwnedMedicineCounter)
           {
               if (countExisting.Value > 5)
               {
                   return false;
               }
                else
               {
                   return true;
               }
            }

            return true; 
      }

     

        public void updateOwnedMedicineCounter(String email)
        {
            User user = new User();
            user = userRepository.getByEmail(email);
            Dictionary<String, int> MedicineOwned = new Dictionary<string, int>();
            

            foreach (Bill b in user.Bills)
            {
                foreach(String t in b.MedicineAndQuantity.Keys)
                {
                    if (MedicineOwned.Keys.FirstOrDefault(x => x==t)!=null)
                    {
                        MedicineOwned[t] += b.MedicineAndQuantity[t]; 
                    }
                    else
                    {
                        MedicineOwned.Add(t, b.MedicineAndQuantity[t]);
                    }
                } 
            }
            userRepository.UpdateOwnedMedicineCounter(MedicineOwned,email);
        }

    }
}