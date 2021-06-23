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
        public List<Medicine> MedicineById(String id, List<Medicine> medicines)
      {
           return searchService.MedicineById( id, medicines);
      }
      
      public List<Medicine> MedicineByName(String name, List<Medicine> medicines)
        {

            return searchService.MedicineByName(name, medicines);
        }
      
      public List<Medicine> MedicineByManufacturer( String manufacturer, List<Medicine> medicines)
      {

            return searchService.MedicineByManufacturer( manufacturer, medicines);
      }
      
      public List<Medicine> MedicineByPriceRange( int priceFrom, int priceTo, List<Medicine> medicines)
        {

            return searchService.MedicineByPriceRange( priceFrom, priceTo, medicines);
        }
      
      public List<Medicine> MedicineByQuantity( string quantity, List<Medicine> medicines)
        {

            return searchService.MedicineByQuantity(quantity, medicines);
        }
      
      public List<Medicine> MedicineByComponents(string componentName1, string componentName2,List<Medicine> medicines)
      {
         
         return searchService.MedicineByComponents( componentName1, componentName2, medicines); ;
      }
      
      public List<Model.Component> ComponentByName(String name, List<Model.Component> components)
      {
            return searchService.ComponentByName(name,components);
      }
      
      public List<Model.Component> ComponentByDescription(String description, List<Model.Component> components)
      {
            return searchService.ComponentByDescription(description, components);
      }
      
      public List<Component> ComponentByMedicine(String medicineName1, String medicineName2, List<Model.Component> components)
      {
         
            return searchService.ComponentByMedicine(medicineName1, medicineName2, components);
      }
   
      
   
   }
}