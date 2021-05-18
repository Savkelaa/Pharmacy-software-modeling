using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Model;
using Controller;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Pharmacy.Interface
{
  

    public partial class AllPatients : Window
    {

        
        UserController userController = new UserController();

        public AllPatients()
        {
            InitializeComponent();

            this.gridPatient.ItemsSource = userController.GetAll();
        }

      

        
    }
}
