using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Model;
using Service;

namespace Controller
{ 
    public class UserController
   {
        UserService userService = new UserService();
        public void Save(User newPatient)
      {
            userService.Save(newPatient);
        }
      
      public List<User> GetAll()
      {
            return userService.GetAll();
        }
      
      public User Registration(String email, String password)
      {

           return userService.Registration(email, password);
      }
      
      public Boolean IsJmbgValid(String jmbg)
      {

            return userService.IsJmbgValid(jmbg);
        }
      
      public Boolean IsEmailValid(String email)
      {

            return userService.IsEmailValid(email);
        }
      
      public Boolean CheckOwnedWeek(String email)
      {
            return userService.CheckOwnedWeek(email);
      }
      
      public Boolean CheckOwnedOne(String email)
      {

            return userService.CheckOwnedOne(email);
        
      }
   
   
   }
}