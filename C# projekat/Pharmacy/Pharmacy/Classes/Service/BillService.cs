
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
      

        public void Buy(List<Medicine> medicines)
        {
            Dictionary<string, int> medicineAndQuantity = new Dictionary<string, int>();
            float totalPrice = 0;

            foreach (Medicine m in medicines)
            {
                medicineAndQuantity.Add(m.Name, m.Quantity);
                totalPrice += m.Price * m.Quantity;
            }

            Bill bill = new Bill(GenerateId(), "Pedja", DateTime.Now.ToString("MM/dd/yyyy h:mm tt"), medicineAndQuantity, totalPrice);
            billRepository.Save(bill);
        }
    }
}