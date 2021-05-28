using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using Component = Model.Component;
using Repository;
using Service;

namespace Service
{
   public class SearchService
   {
        MedicineRepository medicineRepository = new MedicineRepository();
        MedicineService medicineService = new MedicineService();

        public List<Medicine> MedicineById(DataGrid gridMedicines, String idSearch)
      {
            if (idSearch.Length >= 3)
            {
                gridMedicines.ItemsSource = null;
                List<Medicine> allMedicines = new List<Medicine>(medicineRepository.GetAll());
                List<Medicine> searchedMedicines = new List<Medicine>();
                foreach (Medicine m in allMedicines)
                {
                   if((m.Id.Contains(idSearch)))
                    {
                        searchedMedicines.Add(m);
                    }
                }
                return searchedMedicines;
            }
            else
            { 
                return medicineService.GetAllAccepted();   //vidi za ovo
            }
                
      }
      
      public List<Medicine> MedicineByName(String name)
      {
         
         return null;
      }
      
      public List<Medicine> MedicineByManufacturer(String manufacturer)
      {
         
         return null;
      }
      
      public List<Medicine> MedicineByPriceRange(int priceRange)
      {
         
         return null;
      }
      
      public List<Medicine> MedicineByQuantity(int quantity)
      {
         
         return null;
      }
      
      public List<Medicine> MedicineByComponents()
      {
         
         return null;
      }
      
      public List<Component> ComponentByName(String name)
      {
         
         return null;
      }
      
      public List<Component> ComponentByDescription(String description)
      {
         
         return null;
      }
      
      public List<Component> ComponentByMedicine()
      {
         
         return null;
      }
   
     
   
   }
}