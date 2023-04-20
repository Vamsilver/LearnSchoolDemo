using LanguageSchoolPractice.ADO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace LanguageSchoolPractice
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        string Test = "test";

        public static readonly LanguageSchoolEntities Connection = new LanguageSchoolEntities();

        public static Brush ExtraBackground = new SolidColorBrush(Color.FromRgb(231, 250, 191));

        public static bool IsAdmin = false;

        public static Visibility IsAdminVisible = IsAdmin ? Visibility.Visible : Visibility.Hidden;

    }
}
