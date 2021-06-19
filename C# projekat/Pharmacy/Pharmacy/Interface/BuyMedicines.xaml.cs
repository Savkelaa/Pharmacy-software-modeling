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
using Controller;

namespace Pharmacy.Interface
{
    
    public partial class BuyMedicines : Window
    {
        User u = new User();
        MedicineController medicineController = new MedicineController();
        BillController billController = new BillController();
        UserController userController = new UserController();

      //  int cartQuantity;

        public BuyMedicines(User user)
        {
           
            InitializeComponent();
            u = user;
          //  cartQuantity = newQuantity;
            ObservableCollection<Medicine> acceptedMedicines = new ObservableCollection<Medicine>(medicineController.GetAllProducts());
            this.gridAccepted.ItemsSource = acceptedMedicines;
        }

        
        //public void TransferQuantity(int newQuantity)
        //{
        //    cartQuantity = newQuantity;
            
        //}


        private void Add_To_Cart_Click(object sender, RoutedEventArgs e)
        {
           
            if (gridAccepted.SelectedItems.Count > 0)
            {
               
                var cellInfo = gridAccepted.SelectedCells[4];    
                var s = new SelectValue(u);
                s.quantity = Convert.ToInt32((cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text);
                s.ShowDialog();

                if(s.isBought)
                {
                    Medicine medicine = (Medicine)gridAccepted.SelectedItem;
                    medicine.Quantity = s.quantity; 
                    cart.Items.Add(medicine);
                }
               
                

            }
            else
            {
                MessageBox.Show("You need to select one of medicine", "Error");
            }
        }

        private void Delete_From_Cart_Click(object sender, RoutedEventArgs e)
        {
            cart.Items.Remove(cart.SelectedItem);
        }


        private void Buy_Click(object sender, RoutedEventArgs e)
        {

            List<Medicine> cartMedicines = cart.Items.OfType<Medicine>().ToList();
           
            Dictionary<String, int> dictCart = new Dictionary<String, int>();

            foreach (Medicine m in cartMedicines)
            {
                dictCart.Add(m.Name, m.Quantity);     
            }

         

            if ((userController.CheckOwnedWeek(u.Email))  && (userController.CheckOwnedOne(u.Email, dictCart)))
            {
                billController.Buy(cartMedicines, u);
                foreach (Medicine m in cartMedicines)
                {
                    medicineController.UpdateQuantity(m, m.Quantity);
                }
                MessageBox.Show("You have successfully purchased the medication.", "Successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("You cannot buy more than 50 medications a week, or more than 5 of the same medicine.");
            }




           
        }
    }
}
