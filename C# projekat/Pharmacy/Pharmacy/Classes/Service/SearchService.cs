using Model;
using Repository;
using System;
using System.Collections.Generic;
using Component = Model.Component;

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
                if (m.Id.Contains(id))
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
            if (manufacturer.Length >= 3)
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
                if (m.Price >= priceFrom && m.Price <= priceTo)
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

        public List<Medicine> MedicineByComponents(String componentName1, String componentName2, List<Medicine> medicines)
        {
            if (componentName1.Length >= 3 || componentName2.Length >= 3)
            {
                List<Medicine> searchedMedicines1 = new List<Medicine>();
                List<Medicine> searchedMedicines2 = new List<Medicine>();
                List<Medicine> searchedMedicines = new List<Medicine>();

                //Pretrazi po jednom i po drugom i ubaci u nove liste

                foreach (Medicine m in medicines)
                {
                    foreach (KeyValuePair<int, String> c in m.Components)
                    {
                        if (c.Value.Contains(componentName1))
                        {
                            searchedMedicines1.Add(m);
                        }
                    }

                    foreach (KeyValuePair<int, String> c in m.Components)
                    {
                        if (c.Value.Contains(componentName2))
                        {
                            searchedMedicines2.Add(m);
                        }
                    }
                }

                //poredi nove iste i ako se poklapa ubaci u listu koju ces da prikazes

                foreach (Medicine medicine1 in searchedMedicines1)
                {
                    foreach (Medicine medicine2 in searchedMedicines2)
                    {
                        if (medicine1.Name == medicine2.Name)
                        {
                            searchedMedicines.Add(medicine1);
                        }
                    }
                }


                if (componentName2.Length < 3)
                {
                    return searchedMedicines1;
                }
                else
                {
                    return searchedMedicines;
                }

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

        public List<Model.Component> ComponentByMedicine(String medicineName1, String medicineName2, List<Model.Component> components)
        {
            if (medicineName1.Length >= 3 || medicineName2.Length >= 3)
            {
                List<Model.Component> searchedComponents1 = new List<Model.Component>();
                List<Model.Component> searchedComponents2 = new List<Model.Component>();
                List<Model.Component> searchedComponents = new List<Model.Component>();
                List<Medicine> allMedicines = new List<Medicine>(medicineRepository.GetAll());


                foreach (Medicine m in allMedicines)
                {
                    if (m.Name.Contains(medicineName1))
                    {
                        foreach (Component component in components)
                        {
                            foreach (KeyValuePair<int, string> c in m.Components)
                            {
                                if (c.Value == component.Name)
                                    searchedComponents1.Add(component);
                            }
                        }
                    }

                    if (m.Name.Contains(medicineName2))
                    {
                        foreach (Component component in components)
                        {
                            foreach (KeyValuePair<int, string> c in m.Components)
                            {
                                if (c.Value == component.Name)
                                    searchedComponents2.Add(component);
                            }
                        }
                    }


                }

                foreach (Component component1 in searchedComponents1)
                {
                    foreach (Component component2 in searchedComponents2)
                    {
                        if (component1.Name == component2.Name)
                        {
                            searchedComponents.Add(component1);
                        }
                    }
                }

                if (medicineName2.Length < 3)
                {
                    return searchedComponents1;
                }
                else
                {
                    return searchedComponents;
                }

            }
            else
            {
                return components;
            }


        }



    }
}