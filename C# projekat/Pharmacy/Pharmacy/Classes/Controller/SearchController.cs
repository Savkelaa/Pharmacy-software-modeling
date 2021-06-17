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
        public List<Medicine> MedicineById(DataGrid gridMedicines, String idSearch, List<Medicine> medicines)
      {
           return searchService.MedicineById(gridMedicines, idSearch, medicines);
      }
      
      public List<Medicine> MedicineByName(DataGrid gridMedicines, String nameSearch, List<Medicine> medicines)
        {

            return searchService.MedicineByName(gridMedicines, nameSearch, medicines);
        }
      
      public List<Medicine> MedicineByManufacturer(DataGrid gridMedicines, String manufacturerSearch, List<Medicine> medicines)
      {

            return searchService.MedicineByManufacturer(gridMedicines, manufacturerSearch, medicines);
      }
      
      public List<Medicine> MedicineByPriceRange(DataGrid gridMedicines, int priceFrom, int priceTo, List<Medicine> medicines)
        {

            return searchService.MedicineByPriceRange(gridMedicines, priceFrom, priceTo, medicines);
        }
      
      public List<Medicine> MedicineByQuantity(DataGrid gridMedicines, string quantitySearch, List<Medicine> medicines)
        {

            return searchService.MedicineByQuantity(gridMedicines, quantitySearch, medicines);
        }
      
      public List<Medicine> MedicineByComponents()
      {
         
         return null;
      }
      
      public List<Component> ComponentByName(String name, List<Medicine> medicines)
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