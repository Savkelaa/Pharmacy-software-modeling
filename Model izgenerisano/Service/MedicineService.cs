/***********************************************************************
 * Module:  Lek.cs
 * Author:  Nikola
 * Purpose: Definition of the Class Lek
 ***********************************************************************/

using System;

namespace Service
{
   public class MedicineService
   {
      public void Accept(int medicineId)
      {
         
      }
      
      public void Reject(int medicineId)
      {
         
      }
      
      public List<Medicine> GetAll()
      {
         
         return null;
      }
      
      public List<Medicine> GetAllRejected()
      {
         
         return null;
      }
      
      public List<Medicine> GetAllAccepted()
      {
         
         return null;
      }
      
      public List<Medicine> GetAllPending()
      {
         
         return null;
      }
      
      public Medicine Save(Medicine newMedicine)
      {
         
         return null;
      }
      
      public void Delete(int medicineId)
      {
         
      }
      
      public void AddMedicineToCart(int medicineId)
      {
         
      }
      
      public List<Medicine> SearchByPassword(String password)
      {
         
         return null;
      }
      
      public List<Medicine> SearchByName(String name)
      {
         
         return null;
      }
      
      public List<Medicine> SearchByManufacturer(String manufacturer)
      {
         
         return null;
      }
      
      public List<Medicine> SearchByPriceRange(int priceRange)
      {
         
         return null;
      }
      
      public List<Medicine> SearchByQuantity(int quantity)
      {
         
         return null;
      }
      
      public List<Medicine> SearchByComponents()
      {
         
         return null;
      }
      
      public List<Medicine> Buy()
      {
         
         return null;
      }
   
      public Repository.MedicineRepository medicineRepository;
   
   }
}