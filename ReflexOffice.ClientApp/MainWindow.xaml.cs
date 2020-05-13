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
using ReflexOffice.ClientApp.View;

namespace ReflexOffice.ClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Loaded += Window_Loaded;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new StartPage());
        }

        private void btnHomeClick(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new StartPage());
        }

        private void btnItemOverViewClick(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new ItemOverView());
        }

        private void btnSettingClick(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new SettingPage());
        }
    }
}
