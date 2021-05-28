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
                ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineById(gridMedicines, searchId.Text));
                this.gridMedicines.ItemsSource = searchMedicines;
        }

        private void searchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByName(gridMedicines, searchName.Text));
            this.gridMedicines.ItemsSource = searchMedicines;
        }

        private void searchManufacturer_TextChanged(object sender, TextChangedEventArgs e)
        {
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByManufacturer(gridMedicines, searchManufacturer.Text));
            this.gridMedicines.ItemsSource = searchMedicines;
        }

        private void searchQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByQuantity(gridMedicines, searchQuantity.Text));
            this.gridMedicines.ItemsSource = searchMedicines;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineByPriceRange(gridMedicines, Convert.ToInt32(searchPrice1.Text), Convert.ToInt32(searchPrice2.Text)));
                this.gridMedicines.ItemsSource = searchMedicines;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        
    }
}
