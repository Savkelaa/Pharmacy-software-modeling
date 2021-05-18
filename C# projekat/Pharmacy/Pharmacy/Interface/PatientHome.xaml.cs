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

    public partial class PatientHome : Window
    {
        public PatientHome()
        {
            InitializeComponent();
        }

        private void BuyMedicine_Click(object sender, RoutedEventArgs e)
        {
            var s = new BuyMedicines();
            s.Show();
        }

        private void AllBills_Click(object sender, RoutedEventArgs e)
        {
            var s = new AllBills();
            s.Show();
        }
    }
}
