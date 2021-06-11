
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
   public class BillService
   {
        BillRepository billRepository = new BillRepository();
        UserRepository userRepository = new UserRepository();

      public int GenerateId()
        {
            try
            {
                List<Bill> bills = new List<Bill>(billRepository.GetAll());
                int id = bills.Max(b => b.Id);
                return id + 1;
            }
            catch
            {
                return 1;
            }
        }

      public List<Bill> GetAll()
      {
           return billRepository.GetAll();
      }
      

        public void Buy(List<Medicine> medicines, User u)
        {

            Dictionary<string, int> medicineAndQuantity = new Dictionary<string, int>();
            float totalPrice = 0;

            foreach (Medicine m in medicines)
            {
                medicineAndQuantity.Add(m.Name, m.Quantity);
                totalPrice += m.Price * m.Quantity;
            }

            Bill bill = new Bill(GenerateId(), "Pedja", DateTime.Now, medicineAndQuantity, totalPrice);
            billRepository.Save(bill);
            SaveBill(u,bill);

        }

        public void SaveBill(User patient, Bill bill)
        {

            List<User> korisnici = userRepository.GetAll();
            foreach (User u in korisnici)
            {
                if (u.Email == patient.Email)
                {
                    u.Bills.Add(bill);   
                }
            }
            userRepository.SaveBill(korisnici);
        }
    }
}