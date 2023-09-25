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
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ProductViewComponent product = new ProductViewComponent();
            MainWP.Children.Add(product);
            ProductViewComponent product1 = new ProductViewComponent();
            MainWP.Children.Add(product1);
            ProductViewComponent product2 = new ProductViewComponent();
            MainWP.Children.Add(product2);
            ProductViewComponent product3 = new ProductViewComponent();
            MainWP.Children.Add(product3);
            ProductViewComponent product4 = new ProductViewComponent();
            MainWP.Children.Add(product4);
        }
    }
}
