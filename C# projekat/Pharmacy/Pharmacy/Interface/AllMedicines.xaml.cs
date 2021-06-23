using Controller;
using Model;
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


namespace Pharmacy.Interface
{
    public partial class AllMedicines : Window
    {
        MedicineController medicineController = new MedicineController();
        SearchController searchController = new SearchController();

        public AllMedicines()
        {
            InitializeComponent();


            ObservableCollection<Medicine> medicines = new ObservableCollection<Medicine>(medicineController.GetAll());

            this.gridMedicines.ItemsSource = medicines;

        }

        private void searchId_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> medicines = medicineController.GetAll();
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineById(searchId.Text, medicines));
            this.gridMedicines.ItemsSource = searchMedicines;
        }

        private void searchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> medicines = medicineController.GetAll();
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByName(searchName.Text, medicines));
            this.gridMedicines.ItemsSource = searchMedicines;
        }

        private void searchManufacturer_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> medicines = medicineController.GetAll();
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByManufacturer(searchManufacturer.Text, medicines));
            this.gridMedicines.ItemsSource = searchMedicines;
        }

        private void searchQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> medicines = medicineController.GetAll();
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByQuantity(searchQuantity.Text, medicines));
            this.gridMedicines.ItemsSource = searchMedicines;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                List<Medicine> medicines = medicineController.GetAll();
                ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByPriceRange(Convert.ToInt32(searchPrice1.Text), Convert.ToInt32(searchPrice2.Text), medicines));
                this.gridMedicines.ItemsSource = searchMedicines;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void comp1_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> medicines = medicineController.GetAll();
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByComponents(comp1.Text,comp2.Text, medicines));
            this.gridMedicines.ItemsSource = searchMedicines;
        }

        private void comp2_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> medicines = medicineController.GetAll();
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByComponents(comp2.Text, comp1.Text, medicines));
            this.gridMedicines.ItemsSource = searchMedicines;
        }

       
    }
}
