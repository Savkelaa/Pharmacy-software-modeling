using Controller;
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
    



    public partial class AllComponents : Window
    {
        Controller.ComponentController componentController = new Controller.ComponentController();
        SearchController searchController = new SearchController();
        public AllComponents()
        {
            InitializeComponent();
            this.gridComponent.ItemsSource = componentController.GetAll();

        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
              List<Model.Component> components = componentController.GetAll();
              ObservableCollection<Model.Component> searchComponents = new ObservableCollection<Model.Component>(searchController.ComponentByName(tbName.Text,components));
              this.gridComponent.ItemsSource = searchComponents;
        }

        private void tbDesc_TextChanged(object sender, TextChangedEventArgs e)
        {
              List<Model.Component> components = componentController.GetAll();
              ObservableCollection<Model.Component> searchComponents = new ObservableCollection<Model.Component>(searchController.ComponentByDescription(tbDesc.Text, components));
            this.gridComponent.ItemsSource = searchComponents;
        }

        

        
        private void tbMedicine1_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Model.Component> components = componentController.GetAll();
            ObservableCollection<Model.Component> searchComponents = new ObservableCollection<Model.Component>(searchController.ComponentByMedicine(tbMedicine1.Text, tbMedicine2.Text, components));
            this.gridComponent.ItemsSource = searchComponents;
        }

        private void tbMedicine2_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Model.Component> components = componentController.GetAll();
            ObservableCollection<Model.Component> searchComponents = new ObservableCollection<Model.Component>(searchController.ComponentByMedicine(tbMedicine2.Text, tbMedicine1.Text, components));
            this.gridComponent.ItemsSource = searchComponents;
        }

       
    }
}
