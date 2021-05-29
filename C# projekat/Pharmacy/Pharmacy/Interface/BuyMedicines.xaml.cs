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

        private void Add_To_Cart_Click(object sender, RoutedEventArgs e)
        {
           
            if (gridAccepted.SelectedItems.Count > 0)
            {
              
                var cellInfo = gridAccepted.SelectedCells[4];    
                var s = new SelectValue();
                s.quantity = Convert.ToInt32((cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text);
                s.ShowDialog();
                if(s.isBought)
                cart.Items.Add(gridAccepted.SelectedItem);  
            }
            else
            {
                MessageBox.Show("You need to select one of medicine", "Error");
            }
               


        }

        private void Delete_From_Cart_Click(object sender, RoutedEventArgs e)
        {
            cart.Items.Remove(cart.SelectedItem);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
