
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class BillRepository
   {
        private String path = "bills.json";
        public List<Bill> bills = new List<Bill>();

        public BillRepository()
        {
            bills = new List<Bill>();
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    bills = JsonConvert.DeserializeObject<List<Bill>>(json);
                }
            }
        }

        public void WriteInJson()
        {
            String json = JsonConvert.SerializeObject(bills, Formatting.Indented);
            File.WriteAllText(path, json);
        }


        public List<Bill> GetAll()
        {
            return bills;
        }
      
      public void Save(Bill newBill)
      {
            bills.Add(newBill);
            WriteInJson();
      }
   
      
   
   }
}