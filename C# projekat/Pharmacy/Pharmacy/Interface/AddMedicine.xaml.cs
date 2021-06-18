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
        ComponentController componentController = new ComponentController();

        public AddMedicine()
        {
            InitializeComponent();
            List <Component> components = new List<Component>(componentController.GetAll());
            foreach(Component c in components)
            {
                lbComponents.Items.Add(c.Id + " " + c.Name);
            }
          
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void SendRequest_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<int, string> dictComponents = new Dictionary<int, string>();
         
            foreach (Object o in lbComponents.SelectedItems)
            {
                int id = Int32.Parse(o.ToString().Substring(0, 1));
                string name= o.ToString().Substring(2, o.ToString().Length - 2);
               
                dictComponents.Add( id ,name);
            }


            try
            {

                Medicine medicineRequest = new Medicine(Id.Text, Name.Text, Manufacturer.Text, Convert.ToSingle(Price.Text), Convert.ToInt32(Quantity.Text), false, false,dictComponents);
                medicineController.Save(medicineRequest);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           // MessageBox.Show("You have successfully sent the request", "Successful");
        }
    }
}
