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
     
        public List<Medicine> MedicineById(DataGrid gridMedicines, String idSearch, List<Medicine> medicines)
      {     
                List<Medicine> listMedicines = new List<Medicine>(medicines);
                List<Medicine> searchedMedicines = new List<Medicine>();
                foreach (Medicine m in listMedicines)
                {
                   if((m.Id.Contains(idSearch)))
                    {
                        searchedMedicines.Add(m);
                    }
                }
                return searchedMedicines;
      }
      
      public List<Medicine> MedicineByName(DataGrid gridMedicines, String nameSearch, List<Medicine> medicines)
        {
            if (nameSearch.Length >= 3)
            {
                gridMedicines.ItemsSource = null;
                List<Medicine> listMedicines = new List<Medicine>(medicines);
                List<Medicine> searchedMedicines = new List<Medicine>();
                foreach (Medicine m in listMedicines)
                {
                    if ((m.Name.Contains(nameSearch)))
                    {
                        searchedMedicines.Add(m);
                    }
                }
                return searchedMedicines;
            }
            else
            {
                return medicines;   
            }
        }
      
      public List<Medicine> MedicineByManufacturer(DataGrid gridMedicines, String manufacturerSearch, List<Medicine> medicines)
        { 
            if(manufacturerSearch.Length >= 3)
            {
                gridMedicines.ItemsSource = null;
                List<Medicine> listMedicines = new List<Medicine>(medicines);
                List<Medicine> searchedMedicines = new List<Medicine>();
                foreach (Medicine m in listMedicines)
                {
                    if ((m.Manufacturer.Contains(manufacturerSearch)))
                    {
                        searchedMedicines.Add(m);
                    }
                }
                return searchedMedicines;
            }
            else
            {
                return medicines;   
            }
        }
      
      public List<Medicine> MedicineByPriceRange(DataGrid gridMedicines, int priceFrom, int priceTo, List<Medicine> medicines)
        {

            gridMedicines.ItemsSource = null;
            List<Medicine> listMedicines = new List<Medicine>(medicines);
            List<Medicine> searchedMedicines = new List<Medicine>();
            foreach (Medicine m in listMedicines)
            {
                if (m.Price>= priceFrom && m.Price<=priceTo)
                {
                    searchedMedicines.Add(m);
                }
            }
            return searchedMedicines;
        }
      
      public List<Medicine> MedicineByQuantity(DataGrid gridMedicines, string quantitySearch, List<Medicine> medicines)
        {
            gridMedicines.ItemsSource = null;
            List<Medicine> listMedicines = new List<Medicine>(medicines);
            List<Medicine> searchedMedicines = new List<Medicine>();
            foreach (Medicine m in listMedicines)
            {
                if ((Convert.ToString(m.Quantity).Contains(quantitySearch)))
                {
                    searchedMedicines.Add(m);
                }
            }
            return searchedMedicines;
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