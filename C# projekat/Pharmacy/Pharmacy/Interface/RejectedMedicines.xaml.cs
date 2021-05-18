﻿using Controller;
using Model;
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
    /// <summary>
    /// Interaction logic for RejectedMedicines.xaml
    /// </summary>
    public partial class RejectedMedicines : Window
    {

        MedicineController medicineController = new MedicineController();

        public RejectedMedicines()
        {
            InitializeComponent();


            ObservableCollection<Medicine> rejectedMedicines = new ObservableCollection<Medicine>(medicineController.GetAllRejected());
            this.gridRejected.ItemsSource = rejectedMedicines;
        }
    }
}