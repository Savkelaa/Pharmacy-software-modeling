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

        public User Registration(String jmbg, String password)
        {

            return userService.Registration(jmbg, password);
        }

        public Boolean IsJmbgValid(String jmbg)
        {

            return userService.IsJmbgValid(jmbg);
        }

        public Boolean IsEmailValid(String email)
        {

            return userService.IsEmailValid(email);
        }

        public Boolean CheckOwnedWeek(String email, int cartQuantity)
        {
            return userService.CheckOwnedWeek(email, cartQuantity);
        }

        public Boolean CheckOwnedOne(String email,Dictionary <String,int> dictCart)
        {

            return userService.CheckOwnedOne(email, dictCart);

        }

       
        public void updateOwnedMedicineCounter(String email)
        {
             userService.updateOwnedMedicineCounter(email);
        }


}
}