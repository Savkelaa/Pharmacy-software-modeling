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
  
    public partial class DoctorHome : Window
    {
        Frame wframe;

        public DoctorHome()
        {
            InitializeComponent();
            
        }

        private void Patients_Click(object sender, RoutedEventArgs e)
        {
            var s = new AllPatients();
            s.Show();
            
        }

        private void Medicines_Click(object sender, RoutedEventArgs e)
        {
            var s = new AllProducts();
            s.Show();
        }

        private void Add_Patient_Click(object sender, RoutedEventArgs e)
        {
            var s = new AddPatient();
            s.Show();
        }
        private void MedicinesRequests_Click(object sender, RoutedEventArgs e)
        {
            var s = new MedicinesRequests();
            s.Show();
        }

        private void AllComponents_Click(object sender, RoutedEventArgs e)
        {
            var s = new AllComponents();
            s.Show();
        }
    }
}
