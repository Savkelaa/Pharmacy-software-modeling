using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using Component = Model.Component;

namespace Controller
{
   public class SearchController
   {
        SearchService searchService = new SearchService();
        public List<Medicine> MedicineById(DataGrid gridMedicines, String idSearch)
      {
           return searchService.MedicineById(gridMedicines, idSearch);
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