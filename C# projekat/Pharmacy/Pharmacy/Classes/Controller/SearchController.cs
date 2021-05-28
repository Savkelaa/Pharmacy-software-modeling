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
      
      public List<Medicine> MedicineByName(DataGrid gridMedicines, String nameSearch)
        {

            return searchService.MedicineByName(gridMedicines, nameSearch);
        }
      
      public List<Medicine> MedicineByManufacturer(DataGrid gridMedicines, String manufacturerSearch)
      {

            return searchService.MedicineByManufacturer(gridMedicines, manufacturerSearch);
      }
      
      public List<Medicine> MedicineByPriceRange(DataGrid gridMedicines, int priceFrom, int priceTo)
        {

            return searchService.MedicineByPriceRange(gridMedicines, priceFrom, priceTo);
        }
      
      public List<Medicine> MedicineByQuantity(DataGrid gridMedicines, string quantitySearch)
        {

            return searchService.MedicineByQuantity(gridMedicines, quantitySearch);
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