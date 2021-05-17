
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Repository
{
   public class RejectedMedicineRepository
   {
        private String path = "rejectedMedicines.json";
        public List<Medicine> rejectedMedicines = new List<Medicine>();
        public RejectedMedicineRepository()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    rejectedMedicines = JsonConvert.DeserializeObject<List<Medicine>>(json);
                }
            }
        }

        public void WriteInJson()
        {
            String json = JsonConvert.SerializeObject(rejectedMedicines, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public List<Medicine> GetAll()
        {
            return rejectedMedicines;
        }

        public void Save(Medicine newMedicine)
        {
            rejectedMedicines.Add(newMedicine);
            WriteInJson();

        }
        //public void Update(Medicine medicine)
        //{
        //    int index = medicines.FindIndex(obj => obj.Id == medicine.Id);
        //    medicines[index].Accepted = true;
        //    WriteInJson();

        //}

        public void Delete(String medicineId)
        {
            int index = rejectedMedicines.FindIndex(obj => obj.Id == medicineId);
            rejectedMedicines.RemoveAt(index);
            WriteInJson();
        }



    }
}