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
        public List<Medicine> MedicineById(String id, List<Medicine> medicines)
      {     
                List<Medicine> searchedMedicines = new List<Medicine>();
                foreach (Medicine m in medicines)
                {
                   if(m.Id.Contains(id))
                    {
                        searchedMedicines.Add(m);
                    }
                }
                return searchedMedicines;
      }
      
      public List<Medicine> MedicineByName(String name, List<Medicine> medicines)
        {
            if (name.Length >= 3)
            {            
                List<Medicine> searchedMedicines = new List<Medicine>();
                foreach (Medicine m in medicines)
                {
                    if ((m.Name.Contains(name)))
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
      
      public List<Medicine> MedicineByManufacturer(String manufacturer, List<Medicine> medicines)
        { 
            if(manufacturer.Length >= 3)
            { 
                List<Medicine> searchedMedicines = new List<Medicine>();
                foreach (Medicine m in medicines)
                {
                    if ((m.Manufacturer.Contains(manufacturer)))
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
      
      public List<Medicine> MedicineByPriceRange(int priceFrom, int priceTo, List<Medicine> medicines)
        {

            
            List<Medicine> searchedMedicines = new List<Medicine>();
            foreach (Medicine m in medicines)
            {
                if (m.Price>= priceFrom && m.Price<=priceTo)
                {
                    searchedMedicines.Add(m);
                }
            }
            return searchedMedicines;
        }
      
      public List<Medicine> MedicineByQuantity(string quantitySearch, List<Medicine> medicines)
        {
            
            
            List<Medicine> searchedMedicines = new List<Medicine>();
            foreach (Medicine m in medicines)
            {
                if (Convert.ToString(m.Quantity).Contains(quantitySearch))
                {
                    searchedMedicines.Add(m);
                }
            }
            return searchedMedicines;
        }
      
      public List<Medicine> MedicineByComponents(string componentName, List<Medicine> medicines)
      {
            if (componentName.Length >= 3)
            {
                List<Medicine> searchedMedicines = new List<Medicine>();
                foreach (Medicine m in medicines)
                {
                   foreach (KeyValuePair<int, String> c in m.Components)
                    {
                        if(c.Value.Contains(componentName))
                        {
                            searchedMedicines.Add(m);
                        }
                    }
                }
                return searchedMedicines;
            }
            else
            {
                return medicines;
            }

          
      }
      
      public List<Model.Component> ComponentByName(String name, List<Model.Component> components)
      {
            if (name.Length >= 3)
            {
                List<Model.Component> searchedComponents = new List<Model.Component>();

                foreach (Model.Component c in components)
                {
                    if (c.Name.Contains(name))
                    {
                        searchedComponents.Add(c);
                    }
                }
                return searchedComponents;
            }
            else
            {
                  return components;
            }

            
        }

      public List<Component> ComponentByDescription(String description, List<Model.Component> components)
      { 
            if (description.Length >= 3)
            {
                List<Model.Component> searchedComponents = new List<Model.Component>();
                foreach (Model.Component c in components)
                {
                    if (c.Description.Contains(description))
                    {
                        searchedComponents.Add(c);
                    }
                }
                return searchedComponents;
            }
            else
            {
                return components;
            }
         
      }
      
      public List<Model.Component> ComponentByMedicine(String medicineName, List<Model.Component> components)
      {
            if (medicineName.Length >= 3)
            {
                List<Model.Component> searchedComponents = new List<Model.Component>();
                List<Medicine> allMedicines = new List<Medicine>(medicineRepository.GetAll());


                foreach (Medicine m in allMedicines)
                {
                    if (m.Name.Contains(medicineName))
                    {
                        foreach(Component component in components)
                            {
                            foreach(KeyValuePair<int, string> c in m.Components)
                                {
                                if (c.Value==component.Name)
                                    searchedComponents.Add(component);
                                }
                             }                              
                    } 
                }
                return searchedComponents;
            }
            else
            {
                return components;
            }
           
           
      }
   
     
   
   }
}