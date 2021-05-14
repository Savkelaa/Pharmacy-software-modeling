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

            User tacnost = new User();
            tacnost =  userController.Registration(email, password);
            



            if (tacnost != null)
            { 
                var s = new Interface.DoctorHome();
                s.Show();
            }


            




        }
    }
}
