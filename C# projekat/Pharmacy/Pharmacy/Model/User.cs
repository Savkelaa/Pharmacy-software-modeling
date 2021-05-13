

using System;

namespace Model
{
   public class User
   {
      public System.Collections.ArrayList bill;
      
      
      public System.Collections.ArrayList GetBill()
      {
         if (bill == null)
            bill = new System.Collections.ArrayList();
         return bill;
      }
      
      
      public void SetBill(System.Collections.ArrayList newBill)
      {
         RemoveAllBill();
         foreach (Bill oBill in newBill)
            AddBill(oBill);
      }
      
      
      public void AddBill(Bill newBill)
      {
         if (newBill == null)
            return;
         if (this.bill == null)
            this.bill = new System.Collections.ArrayList();
         if (!this.bill.Contains(newBill))
            this.bill.Add(newBill);
      }
      
      
      public void RemoveBill(Bill oldBill)
      {
         if (oldBill == null)
            return;
         if (this.bill != null)
            if (this.bill.Contains(oldBill))
               this.bill.Remove(oldBill);
      }
      
      
      public void RemoveAllBill()
      {
         if (bill != null)
            bill.Clear();
      }
   
      private String jmbg;
      private String email;
      private String password;
      private String name;
      private String surname;
      private String mobilePhone;
      private UserType type;
   
   }
}