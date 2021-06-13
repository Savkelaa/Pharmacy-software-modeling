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
using Controller;



namespace Pharmacy.Interface
{
  
    public partial class AddPatient : Window
    {

        UserController userController = new UserController();

        public AddPatient()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void RegisterPatient(object sender, RoutedEventArgs e)
        {
            String Jmbg = jmbg.Text;
            String Email = email.Text;

            List<Bill> bills = new List<Bill>();


           if (userController.IsJmbgValid(Jmbg)==true && userController.IsEmailValid(Email)==true)
            {
                User newPatient = new User(jmbg.Text, email.Text, password.Text, name.Text, surname.Text, phone.Text, userType.Text);
                userController.Save(newPatient);
            }
           else
            {
                MessageBox.Show("There is a Patient with an entered password or email!!","Error");
            }
            
        }
    }
}
