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
    /// Interaction logic for LaptopPage.xaml
    /// </summary>
    public partial class LaptopPage : Page
    {
        public LaptopPage()
        {
            InitializeComponent();
        }

        private void btnSellerCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LaptopViewComponent laptop = new LaptopViewComponent();
            MainWP.Children.Add(laptop);
            LaptopViewComponent laptop1 = new LaptopViewComponent();
            MainWP.Children.Add(laptop1);
            LaptopViewComponent laptop2 = new LaptopViewComponent();
            MainWP.Children.Add(laptop2);
        }
    }
}
