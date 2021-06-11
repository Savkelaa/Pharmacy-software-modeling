

using Model;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class BillController
   {
        BillService billService = new BillService();
        public int GenerateId()
        {
           return billService.GenerateId();
        }

       



        public List<Bill> GetAll()
        {
          return billService.GetAll();   
        }
      

        public void Buy(List<Medicine> medicines,User u)
        {
            billService.Buy(medicines,u);
        }
    }
}