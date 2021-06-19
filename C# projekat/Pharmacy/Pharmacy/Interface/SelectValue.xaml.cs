using Model;
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
    public partial class SelectValue : Window
    {
        User u = new User();
        public int quantity { get; set; }
        public bool isBought = false;
        public SelectValue(User user)
        {
            u = user;

            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            if (quantity >= Convert.ToInt32(tbQuantity.Text))
            {
                quantity = Convert.ToInt32(tbQuantity.Text);
                isBought = true;
                
          //      var q = new BuyMedicines(Convert.ToInt32(tbQuantity.Text),u);
               // q.TransferQuantity(Convert.ToInt32(tbQuantity.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter a quantity that is less than the current one","Error");
            } 
        }
    }
}
