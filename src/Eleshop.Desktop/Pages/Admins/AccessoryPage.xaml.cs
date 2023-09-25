using Eleshop.Desktop.Components.Admins;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Eleshop.Desktop.Pages.Admins
{
    /// <summary>
    /// Interaction logic for AccessoryPage.xaml
    /// </summary>
    public partial class AccessoryPage : Page
    {
        public AccessoryPage()
        {
            InitializeComponent();
        }


        private void btnLaptopCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AccessoryViewComponent accessory = new AccessoryViewComponent();
            MainWP.Children.Add(accessory);
            AccessoryViewComponent accessory2 = new AccessoryViewComponent();
            MainWP.Children.Add(accessory2);
            AccessoryViewComponent accessory3 = new AccessoryViewComponent();
            MainWP.Children.Add(accessory3);
        }
    }
}
