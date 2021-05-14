using System;

namespace Model
{
   public class Bill
   {
      public int Id;
      public String Pharmacist;
      public String DateTime;
      public Dictionary<String, int> MedicineAndQuantity;
      public float TotalPrice;
      
      public System.Collections.ArrayList medicine;
      
      
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