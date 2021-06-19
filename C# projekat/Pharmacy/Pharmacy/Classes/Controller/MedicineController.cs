

using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Controller
{
   public class MedicineController
   {

      MedicineService medicineService = new MedicineService();

      public void UpdateAccept(Medicine medicine)
      {
           medicineService.UpdateAccept(medicine);
      }

      public void UpdateDelete(String medicineId)
      {
           medicineService.UpdateDelete(medicineId);
      }

  
        public void UpdateQuantity(Medicine m, int quantity)
        {
            medicineService.UpdateQuantity(m, quantity);
        }



        public List<Medicine> GetAll()
        {
            return medicineService.GetAll();
        }

        public List<Medicine> GetAllProducts()
      {

            return medicineService.GetAllProducts();
      }

        public List<Medicine> GetAllRequests()
        {
            return medicineService.GetAllRequests();
        }

        public List<Medicine> GetAllRejected()
      {

            return medicineService.GetAllRejected();
      }
    
      public List<Medicine> GetAllAccepted()
      {

            return medicineService.GetAllAccepted();
      }

     

        public void Save(Medicine newMedicine)
      {
            medicineService.Save(newMedicine);
      }

        public void SaveRejected(Medicine newMedicine)
        {
            medicineService.SaveRejected(newMedicine);
        }

        public void Delete(String medicineId)
      {
            medicineService.Delete(medicineId);
      }

        
   
      
   
   }
}