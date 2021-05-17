

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

      public void UpdateAccepted(Medicine medicine)
      {
           medicineService.UpdateAccepted(medicine);
      }

      public void UpdateDeleted(String medicineId)
      {
           medicineService.UpdateDeleted(medicineId);
      }

        public void Reject(int medicineId)
      {
         
      }
      
      public List<Medicine> GetAll()
      {

            return medicineService.GetAll();
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

        

        public void AddMedicineToCart(int medicineId)
      {
         
      }
      
      public List<Medicine> Buy()
      {
         
         return null;
      }
   
      
   
   }
}