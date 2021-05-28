using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Controller;
using Model;


namespace Pharmacy.Interface
{
   
    public partial class AddMedicine : Window
    {
        MedicineController medicineController = new MedicineController();
        public AddMedicine()
        {
            InitializeComponent();



        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void SendRequest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medicine medicineRequest = new Medicine(Id.Text, Name.Text, Manufacturer.Text, Convert.ToSingle(Price.Text), Convert.ToInt32(Quantity.Text), false, false);
                medicineController.Save(medicineRequest);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            MessageBox.Show("You have successfully sent the request", "Successful");
        }
    }
}
