using Eleshop.Desktop.Pages.Admins;
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

namespace Eleshop.Desktop.Windows.Admins
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }


        private void rbProducts_Click(object sender, RoutedEventArgs e)
        {
            ProductPage laptop = new ProductPage();
            PageNavigator.Content=laptop;
            
        }


        private void rbAccessories_Click(object sender, RoutedEventArgs e)
        {
            AccessoryPage accessory = new AccessoryPage();
            PageNavigator.Content= accessory;
        }

        private void rbPhones_Click(object sender, RoutedEventArgs e)
        {
            PhonePage phone = new PhonePage();
            PageNavigator.Content = phone;
        }

        private void rbLaptops_Click(object sender, RoutedEventArgs e)
        {
            LaptopPage laptop = new LaptopPage();
            PageNavigator.Content=laptop;
        }

        private void btShoppingChart(object sender, RoutedEventArgs e)
        {

        }
    }
}
