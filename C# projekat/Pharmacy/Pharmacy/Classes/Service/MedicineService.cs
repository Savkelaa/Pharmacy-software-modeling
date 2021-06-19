
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Service
{
   public class MedicineService
   {

      MedicineRepository medicineRepository = new MedicineRepository();
      RejectedMedicineRepository rejectedMedicineRepository = new RejectedMedicineRepository();

        public void UpdateAccept(Medicine medicine)
        {
            medicineRepository.UpdateAccept(medicine);  
        }

        public void UpdateDelete(String medicineId)
        {     
             medicineRepository.UpdateDelete(medicineId);
        }


        public void UpdateQuantity(Medicine m, int quantity)
        { 
            medicineRepository.UpdateQuantity(m.Id, m.Quantity - quantity);
        }

        public List<Medicine> GetAllProducts()
        {
            List<Medicine> allMedicines = new List<Medicine>(medicineRepository.GetAll());
            List<Medicine> products = new List<Medicine>();
            foreach (Medicine m in allMedicines)
            {
                if (m.Accepted == true && m.Deleted == false)
                {
                    products.Add(m);
                }
            }
            return products;
        }

        public List<Medicine> GetAllRequests()
        {
            List<Medicine> allMedicines = new List<Medicine>(medicineRepository.GetAll());
            List<Medicine> requests = new List<Medicine>();

            foreach(Medicine m in allMedicines)
               {
                    if(m.Accepted == false && m.Deleted==false)
                    {
                       requests.Add(m);
                    }
               }
               return requests;
        }

        public List<Medicine> GetAll()
        {
            return medicineRepository.GetAll();
        }

        public List<Medicine> GetAllRejected()
        {
         return rejectedMedicineRepository.GetAll();
        }
      
      public List<Medicine> GetAllAccepted()
      {
           List<Medicine> allMedicines = new List<Medicine>(medicineRepository.GetAll());
           List<Medicine> accepted = new List<Medicine>();
           foreach (Medicine m in allMedicines)
           {
              if (m.Accepted == true)
              {
                   accepted.Add(m);
              }
           }
           return accepted;       
      }

       
        public void Save(Medicine newMedicine)
      {
            medicineRepository.Save(newMedicine);
      }

      public void SaveRejected(Medicine newMedicine)
      {
           rejectedMedicineRepository.Save(newMedicine);
      }

      public void Delete(String medicineId)
      {
            medicineRepository.Delete(medicineId);
      }


   
   }
}