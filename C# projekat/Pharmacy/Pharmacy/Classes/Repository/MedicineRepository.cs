

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;

namespace Repository
{
   public class MedicineRepository
   {

        private String path = "medicines.json";
        public List<Medicine> medicines= new List<Medicine>();

        public MedicineRepository()
        {
            medicines = new List<Medicine>();
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    medicines = JsonConvert.DeserializeObject<List<Medicine>>(json);
                }
            }
        }

        public void WriteInJson()
        {
            String json = JsonConvert.SerializeObject(medicines, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public List<Medicine> GetAll()
      {
         return medicines;
      }

        public Medicine getById(String id)
        {
            foreach (Medicine m in medicines)
            {
                if (m.Id == id)
                {
                    return m;
                }
            }
            return null;
        }

        public void Save(Medicine newRequest)
      {
            medicines.Add(newRequest);
            WriteInJson();
         
      }
        public void UpdateAccept(Medicine medicine)
        {
            int index = medicines.FindIndex(obj => obj.Id == medicine.Id);
            medicines[index].Accepted = true;
            WriteInJson();
        }

        public void UpdateDelete(String medicineId)
        {
            int index = medicines.FindIndex(obj => obj.Id==medicineId);
            medicines[index].Deleted = true;
            MessageBox.Show("You have successfully deleted the medicine", "Successful");
            WriteInJson();
        }

        public void UpdateQuantity(String medicineId,int quantity)
        {
            int index = medicines.FindIndex(obj => obj.Id == medicineId);
            medicines[index].Quantity = quantity;
            WriteInJson();
        }

        public void Delete(String medicineId)
        {
            int index = medicines.FindIndex(obj => obj.Id == medicineId);
           
            medicines.RemoveAt(index);
            WriteInJson();
        }

       
    }
}