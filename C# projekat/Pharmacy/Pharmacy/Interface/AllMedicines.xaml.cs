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


            ObservableCollection<Medicine> medicines = new ObservableCollection<Medicine>(medicineController.GetAllAccepted());
           
            this.gridMedicines.ItemsSource = medicines;
            gridMedicines.SelectedValue = 4 ;
        }

        private void searchId_TextChanged(object sender, TextChangedEventArgs e)
        {
                ObservableCollection<Medicine> searchMedicines = new ObservableCollection<Medicine>(searchController.MedicineById(gridMedicines, searchId.Text));
                this.gridMedicines.ItemsSource = searchMedicines;
        }

        

    }
}
