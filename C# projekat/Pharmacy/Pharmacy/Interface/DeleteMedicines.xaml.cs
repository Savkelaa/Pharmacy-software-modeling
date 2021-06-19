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
    /// <summary>
    /// Interaction logic for DeleteMedicines.xaml
    /// </summary>
    public partial class DeleteMedicines : Window
    {

        MedicineController medicineController = new MedicineController();

        public DeleteMedicines()
        {
            InitializeComponent();

           
        }

        private void DeleteMedicine_Click(object sender, RoutedEventArgs e)
        {
            String medicineId = textBox1.Text;
            try
            {
                medicineController.UpdateDelete(medicineId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
