using Controller;
using Model;
using Repository;
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
        User u = new User();
        UserController userController= new UserController();


        public PatientHome(User user)
        {
            InitializeComponent();
            u = user;
            
            surname.Content = u.Name + " " + u.Surname;
            userController.updateOwnedMedicine(u.Email);


        }

        private void BuyMedicine_Click(object sender, RoutedEventArgs e)
        {
           // int clear = 4;
            var s = new BuyMedicines(u);
            s.Show();
        }

        private void AllBills_Click(object sender, RoutedEventArgs e)
        {
            var s = new AllBills(u);
            s.Show();
        }

        private void AllComponentsClick(object sender, RoutedEventArgs e)
        {
            var s = new AllComponents();
            s.Show();
        }

        private void AllProductsClick(object sender, RoutedEventArgs e)
        {
            var s = new AllProducts();
            s.Show();
        }
    }
}
