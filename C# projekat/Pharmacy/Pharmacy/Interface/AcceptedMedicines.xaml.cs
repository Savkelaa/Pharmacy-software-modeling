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
        SearchController searchController = new SearchController();

        public AcceptedMedicines()
        {
            InitializeComponent();
            ObservableCollection<Medicine> acceptedMedicines = new ObservableCollection<Medicine>(medicineController.GetAllAccepted());
            this.gridAccepted.ItemsSource = acceptedMedicines;
        }

        private void searchId_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> medicines = medicineController.GetAllAccepted();
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineById( searchId.Text, medicines));
            this.gridAccepted.ItemsSource = searchMedicines;
        }

        private void searchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> medicines = medicineController.GetAll();
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByName( searchName.Text, medicines));
            this.gridAccepted.ItemsSource = searchMedicines;
        }

        private void searchManufacturer_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> medicines = medicineController.GetAll();
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByManufacturer( searchManufacturer.Text, medicines));
            this.gridAccepted.ItemsSource = searchMedicines;
        }

        private void searchQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> medicines = medicineController.GetAll();
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByQuantity( searchQuantity.Text, medicines));
            this.gridAccepted.ItemsSource = searchMedicines;
        }

        //private void searchPrice1_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}

        //private void searchPrice2_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Medicine> medicines = medicineController.GetAll();
                ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByPriceRange( Convert.ToInt32(searchPrice1.Text), Convert.ToInt32(searchPrice2.Text), medicines));
                this.gridAccepted.ItemsSource = searchMedicines;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
