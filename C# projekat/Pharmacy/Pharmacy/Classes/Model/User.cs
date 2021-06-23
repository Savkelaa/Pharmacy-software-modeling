
using Controller;
using Service;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
    
    public class User
    {
        public String Jmbg { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String MobilePhone { get; set; }
        public String Type { get; set; }

        public Dictionary<String,int> OwnedMedicineCounter { get; set; }

        public List<Bill> Bills {get; set;}
        
        public User(string jmbg, string email, string password, string name, string surname, string mobilePhone, string type, Dictionary<string, int> ownedMedicineCounter, List<Bill> bills )
        {
            Jmbg = jmbg;
            Email = email;
            Password = password;
            Name = name;
            Surname = surname;
            MobilePhone = mobilePhone;
            Type = type;
            OwnedMedicineCounter = ownedMedicineCounter ;
            Bills = bills;
        }


        public User()
        {

        }

    }
}