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

namespace LanguageSchoolPractice.Pages
{
    /// <summary>
    /// Interaction logic for AdminAuthorizationPage.xaml
    /// </summary>
    public partial class AdminAuthorizationPage : Page
    {
        public AdminAuthorizationPage()
        {
            InitializeComponent();
        }
        private void EnterAdminModeBtnClick(object sender, RoutedEventArgs e)
        {
            if (tbAdminPassword.Text == "1234")
                App.IsAdmin = true;

            NavigationService.GoBack();
        }
    }
}
