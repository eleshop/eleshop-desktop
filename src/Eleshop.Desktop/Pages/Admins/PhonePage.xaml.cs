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
    /// Interaction logic for PhonePage.xaml
    /// </summary>
    public partial class PhonePage : Page
    {
        public PhonePage()
        {
            InitializeComponent();
        }

        private void btnPhoneCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PhoneViewComponent phone = new PhoneViewComponent();
            MainWP.Children.Add(phone);
            PhoneViewComponent phone2 = new PhoneViewComponent();
            MainWP.Children.Add(phone2);
            PhoneViewComponent phone3 = new PhoneViewComponent();
            MainWP.Children.Add(phone3);
        }
    }
}
