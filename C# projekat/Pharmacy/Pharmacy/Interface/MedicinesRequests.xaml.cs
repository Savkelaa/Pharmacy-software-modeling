using Controller;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
  
    public partial class MedicinesRequests : Window
    {
        MedicineController medicineController = new MedicineController();
        public MedicinesRequests()
        {
            InitializeComponent();
            this.gridRequests.ItemsSource = medicineController.GetAllRequests();
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            Medicine selectedItem = (Medicine)gridRequests.SelectedItems[0];
            medicineController.SaveRejected(selectedItem);
            medicineController.Delete(selectedItem.Id);
            this.gridRequests.ItemsSource = medicineController.GetAllRequests();
            MessageBox.Show("The medicine has been successfully rejected", "Rejected");
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medicine selectedItem = (Medicine)gridRequests.SelectedItems[0];
                medicineController.UpdateAccepted(selectedItem);
                this.gridRequests.ItemsSource = medicineController.GetAllRequests();
                MessageBox.Show("The medicine has been successfully confirmed", "Accepted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
    }
}
