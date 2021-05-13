using System;
using System.Collections.Generic;
using Model;


namespace Service
{
   public class UserService
   {
      public User Save(User newPatient)
      {
         
         return null;
      }
      
      public List<User> GetAll()
      {
         
         return null;
      }
      
      public User Registration(String email, String password)
      {
         
         return null;
      }
      
      public Boolean IsJmbgValid(String jmbg)
      {
         
         return false;
      }
      
      public Boolean IsEmailValid(String email)
      {
         
         return false;
      }
      
      public Boolean CheckOwnedWeek()
      {
         
         return false;
      }
      
      public Boolean CheckOwnedOne()
      {
         
         return false;
      }
   
      public Repository.UserRepository userRepository;
   
   }
}