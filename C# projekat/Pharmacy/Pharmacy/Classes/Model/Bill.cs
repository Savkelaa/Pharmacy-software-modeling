using System;
using System.Collections;
using System.Collections.Generic;

namespace Model
{
   public class Bill
   {
        public int Id { get; set; }
        public String Pharmacist { get; set; }
        public DateTime DateTime { get; set; }
        public Dictionary<String, int> MedicineAndQuantity { get; set; }
        public float TotalPrice { get; set; }

        public Bill(int id, string pharmacist, DateTime dateTime, Dictionary<string, int> medicineAndQuantity, float totalPrice)
        {
            Id = id;
            Pharmacist = pharmacist;
            DateTime = dateTime;
            MedicineAndQuantity = medicineAndQuantity;
            TotalPrice = totalPrice;
        }

    }
}