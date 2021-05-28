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
      
      public List<Medicine> MedicineByName(DataGrid gridMedicines, String nameSearch)
        {
            if (nameSearch.Length >= 3)
            {
                gridMedicines.ItemsSource = null;
                List<Medicine> allMedicines = new List<Medicine>(medicineRepository.GetAll());
                List<Medicine> searchedMedicines = new List<Medicine>();
                foreach (Medicine m in allMedicines)
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
                return medicineRepository.GetAll();   //vidi za ovo
            }
        }
      
      public List<Medicine> MedicineByManufacturer(DataGrid gridMedicines, String manufacturerSearch)
        { 
            if(manufacturerSearch.Length >= 3)
            {
                gridMedicines.ItemsSource = null;
                List<Medicine> allMedicines = new List<Medicine>(medicineRepository.GetAll());
                List<Medicine> searchedMedicines = new List<Medicine>();
                foreach (Medicine m in allMedicines)
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
                return medicineRepository.GetAll();   //vidi za ovo
            }
        }
      
      public List<Medicine> MedicineByPriceRange(DataGrid gridMedicines, int priceFrom, int priceTo)
        {

            gridMedicines.ItemsSource = null;
            List<Medicine> allMedicines = new List<Medicine>(medicineRepository.GetAll());
            List<Medicine> searchedMedicines = new List<Medicine>();
            foreach (Medicine m in allMedicines)
            {
                if (m.Price>= priceFrom && m.Price<=priceTo)
                {
                    searchedMedicines.Add(m);
                }
            }
            return searchedMedicines;
        }
      
      public List<Medicine> MedicineByQuantity(DataGrid gridMedicines, string quantitySearch)
        {
            gridMedicines.ItemsSource = null;
            List<Medicine> allMedicines = new List<Medicine>(medicineRepository.GetAll());
            List<Medicine> searchedMedicines = new List<Medicine>();
            foreach (Medicine m in allMedicines)
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