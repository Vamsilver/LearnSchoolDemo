using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            WorkspaceFrame.Navigate(new Pages.ServicesPage());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }

        private void AdminModeBtnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminAuthorizationPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            adminModeBtn.Visibility = App.IsAdmin ? Visibility.Collapsed : Visibility.Visible;
        }
    }
}
