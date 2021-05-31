using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pharmacy
{
    public partial class MainWindow : Window
    {

        UserController userController = new UserController();
        private object toString;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogIn(object sender, RoutedEventArgs e)
        {
            String email = LogInEmail.Text;
            String password = LogInPassw.Text;

            User user = new User();
            user =  userController.Registration(email, password);


            if (user != null)
            {
                if (user.Type == "doctor")
                {
                    var s = new Interface.DoctorHome();
                    s.Show();
                }
                else if (user.Type == "pharmacist")
                {
                    var s = new Interface.PharmacistHome();
                    s.Show();
                }
                else if (user.Type == "patient")
                {
                    var s = new Interface.PatientHome();
                    s.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong password or email!", "Error");
            }
            

        }
    }
}
