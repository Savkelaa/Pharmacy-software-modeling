

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
       

      //  private static MedicineRepository _instance;
        public List<Medicine> medicines= new List<Medicine>();

        //public static MedicineRepository Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new MedicineRepository();

        //        }
        //        return _instance;
        //    }
        //}


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
      
      public void Save(Medicine newRequest)
      {
            medicines.Add(newRequest);
            WriteInJson();
         
      }
      public void UpdateAccepted(Medicine medicine)
      {
            //int index = medicines.IndexOf(obj => obj.Id == medicine.Id);
           
            medicine = medicines.FirstOrDefault(obj => obj.Id.Equals(medicine.Id));
            medicine.Accepted = true;
            WriteInJson();

           // medicine= medicines.FirstOrDefault(obj => obj.Id == medicine.Id);


        }

        public void UpdateDeleted(String medicineId)
        {
            Medicine founded = medicines.FirstOrDefault(obj => obj.Id.Equals(medicineId));
            founded.Deleted = true;

            //int index = medicines.IndexOf(obj => obj.Id == medicineId);
            //medicines[index].Deleted = true;
            MessageBox.Show("You have successfully deleted the medicine", "Successful");
            WriteInJson();
        }

        public void Delete(String medicineId)
        {
            Medicine founded = medicines.FirstOrDefault(obj => obj.Id.Equals(medicineId));
            //  int index = medicines.IndexOf(obj => obj.Id == medicineId);
            medicines.Remove(founded);
            WriteInJson();
        }

       
    }
}