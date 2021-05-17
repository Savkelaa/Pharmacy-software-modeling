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

        public AllMedicines()
        {
            InitializeComponent();


            ObservableCollection<Medicine> medicines = new ObservableCollection<Medicine>(medicineController.GetAll());

            this.gridMedicines.ItemsSource = medicines;
        }
    }
}
