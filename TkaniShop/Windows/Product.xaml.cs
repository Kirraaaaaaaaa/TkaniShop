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
using TkaniShop.Tkani_Data_SetTableAdapters;

namespace TkaniShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        Tkani_Data_Set tkani_Data_Set = new Tkani_Data_Set();
        ProductTableAdapter productTableAdapter = new ProductTableAdapter();
        public Product()
        {
            InitializeComponent();
            productTableAdapter.Fill(tkani_Data_Set.Product);
            Product_List.ItemsSource = tkani_Data_Set.Product.DefaultView;
        }

        private void Back_BTN_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            this.Hide();
            authorization.Show();
        }
    }
}
