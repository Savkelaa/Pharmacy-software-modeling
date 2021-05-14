using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
   public class Bill
   {
        public int Id { get; set; }
        public String Pharmacist { get; set; }
        public String DateTime { get; set; }
        public Dictionary<String, int> MedicineAndQuantity { get; set; }
        public float TotalPrice { get; set; }


        public System.Collections.ArrayList medicine;

        public Bill(int id, string pharmacist, string dateTime, Dictionary<string, int> medicineAndQuantity, float totalPrice, ArrayList medicine)
        {
            Id = id;
            Pharmacist = pharmacist;
            DateTime = dateTime;
            MedicineAndQuantity = medicineAndQuantity;
            TotalPrice = totalPrice;
            this.medicine = medicine;
        }

        public System.Collections.ArrayList GetMedicine()
      {
         if (medicine == null)
            medicine = new System.Collections.ArrayList();
         return medicine;
      }
      
      
      public void SetMedicine(System.Collections.ArrayList newMedicine)
      {
         RemoveAllMedicine();
         foreach (Medicine oMedicine in newMedicine)
            AddMedicine(oMedicine);
      }
      
      
      public void AddMedicine(Medicine newMedicine)
      {
         if (newMedicine == null)
            return;
         if (this.medicine == null)
            this.medicine = new System.Collections.ArrayList();
         if (!this.medicine.Contains(newMedicine))
            this.medicine.Add(newMedicine);
      }
      
      
      public void RemoveMedicine(Medicine oldMedicine)
      {
         if (oldMedicine == null)
            return;
         if (this.medicine != null)
            if (this.medicine.Contains(oldMedicine))
               this.medicine.Remove(oldMedicine);
      }
      
      
      public void RemoveAllMedicine()
      {
         if (medicine != null)
            medicine.Clear();
      }
   
   }
}