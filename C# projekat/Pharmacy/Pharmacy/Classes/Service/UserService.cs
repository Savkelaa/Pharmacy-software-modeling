using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

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

            foreach (User u in allEmployees)
            {
                if (u.Type == "patient")
                {
                    patients.Add(u);
                }

            }

            return patients;

        }

        public User Registration(String jmbg, String password)
        {
            List<User> users = userRepository.GetAll();

            foreach (User u in users)
            {
                if ((u.Jmbg == jmbg) && (u.Password == password))
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

        public Boolean CheckOwnedWeek(String email, int cartQuantity)
        {
            User user = new User();
            user = userRepository.GetByEmail(email);
            int count = 0;
            DateTime sevenDays = DateTime.Today.AddDays(-7);

            foreach (KeyValuePair<string, int> dictCounter in user.OwnedMedicineCounter)
            {
                count += dictCounter.Value;
            }

            count = count + cartQuantity;
            

            if (count > 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        


        public Boolean CheckOwnedOne(String email, Dictionary<String, int> dictCart)
        {
            User user = new User();
            user = userRepository.GetByEmail(email);

            Dictionary<String, int> copyOwnedMedicineCounter = new Dictionary<string, int>(user.OwnedMedicineCounter);
            Dictionary<String, int> copy2OwnedMedicineCounter = new Dictionary<string, int>(user.OwnedMedicineCounter);

            if (copyOwnedMedicineCounter.Count == 0)
            {
                copyOwnedMedicineCounter = dictCart;
            }

            foreach (KeyValuePair<String, int> countExisting in copyOwnedMedicineCounter)
            {
                foreach (KeyValuePair<String, int> countCart in dictCart)
                {
                   if (countExisting.Key == countCart.Key)
                  {
                        if (copyOwnedMedicineCounter == dictCart)
                        {
                            copy2OwnedMedicineCounter = copyOwnedMedicineCounter;
                        }
                        else
                        {
                            copy2OwnedMedicineCounter[countExisting.Key] += dictCart[countCart.Key];
                        }
                  }
                   
                }
            }

            foreach (KeyValuePair<String, int> countExisting in copy2OwnedMedicineCounter)
            {
                if (copy2OwnedMedicineCounter[countExisting.Key] >5 ) 
                {
                    return false;
                }    
            }

            return true;
        }

        public void UpdateBill(User userrrr, Bill bill)
        {
            List<User> users = new List<User>(userRepository.GetAll());
            foreach (User user in users)
            {
                if (user.Email == userrrr.Email)
                {
                    user.Bills.Add(bill);
                    userrrr.Bills.Add(bill);
                    userRepository.UpdateBill(users);
                }
            }

            userRepository.UpdateBill(users);
        }

        public void updateOwnedMedicineCounter(String email)
        {
            User user = new User();
            user = userRepository.GetByEmail(email);
            Dictionary<String, int> MedicineOwned = new Dictionary<string, int>();


            foreach (Bill b in user.Bills)
            {
                foreach (String t in b.MedicineAndQuantity.Keys)
                {
                    if (MedicineOwned.Keys.FirstOrDefault(x => x == t) != null)
                    {
                        MedicineOwned[t] += b.MedicineAndQuantity[t];
                    }
                    else
                    {
                        MedicineOwned.Add(t, b.MedicineAndQuantity[t]);
                    }
                }
            }
            userRepository.UpdateOwnedMedicineCounter(MedicineOwned, email);
        }

    }
}