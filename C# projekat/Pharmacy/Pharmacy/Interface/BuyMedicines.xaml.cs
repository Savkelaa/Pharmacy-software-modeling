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
using Controller;

namespace Pharmacy.Interface
{
    
    public partial class BuyMedicines : Window
    {
        MedicineController medicineController = new MedicineController();

        public BuyMedicines()
        {
            InitializeComponent();
            ObservableCollection<Medicine> acceptedMedicines = new ObservableCollection<Medicine>(medicineController.GetAllProducts());
            this.gridAccepted.ItemsSource = acceptedMedicines;
        }
    }
}
