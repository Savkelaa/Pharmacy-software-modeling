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

namespace Pharmacy.Interface
{
   
    public partial class PharmacistHome : Window
    {
        public PharmacistHome()
        {
            InitializeComponent();
            
        }

        private void Medicines_Click(object sender, RoutedEventArgs e)
        {
            var s = new AllMedicines();
            s.Show();
        }

        private void AddMedicine_Click(object sender, RoutedEventArgs e)
        {
            var s = new AddMedicine();
            s.Show();
        }

        private void AcceptedMedicines_Click(object sender, RoutedEventArgs e)
        {
            var s = new AcceptedMedicines();
            s.Show();
        }

        private void RejectedMedicines_Click(object sender, RoutedEventArgs e)
        {
            var s = new RejectedMedicines();
            s.Show();
        }

        private void DeleteMedicines_Click(object sender, RoutedEventArgs e)
        {
            var s = new DeleteMedicines();
            s.Show();
        }

        private void Components_Click(object sender, RoutedEventArgs e)
        {
            var s = new AllComponents();
            s.Show();
        }
    }
}
