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
           // List<User> users = userRepository.GetAll();
           // users.Add(newPatient);
           // userRepository.SaveAll(users);

            userRepository.Save(newPatient);
            MessageBox.Show("Successfully created new patient!");
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
      
      public Boolean CheckOwnedWeek()
      {
         
         return false;
      }
      
      public Boolean CheckOwnedOne()
      {
         
         return false;
      }
   
     
   
   }
}