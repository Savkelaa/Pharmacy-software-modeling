using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    
    public partial class AcceptedMedicines : Window
    {

        MedicineController medicineController = new MedicineController();

        public AcceptedMedicines()
        {
            InitializeComponent();

            ObservableCollection<Medicine> acceptedMedicines = new ObservableCollection<Medicine>(medicineController.GetAllAccepted());
            this.gridAccepted.ItemsSource = acceptedMedicines;
        }

        private void searchId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void searchName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void searchManufacturer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void searchQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void searchPrice1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void searchPrice2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
