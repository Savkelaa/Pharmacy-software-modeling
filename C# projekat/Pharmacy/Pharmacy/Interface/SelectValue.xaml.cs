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
    /// <summary>
    /// Interaction logic for SelectValue.xaml
    /// </summary>
    public partial class SelectValue : Window
    {
        public int quantity { get; set; }
        public bool isBought = false;
        public SelectValue()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BuyMedicines buy = new BuyMedicines();
            if (quantity > Convert.ToInt32(tbQuantity.Text))
            {
                isBought = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter a quantity that is less than the current one","Error");
            } 
        }
    }
}
