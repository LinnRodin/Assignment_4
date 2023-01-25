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

namespace _05_ContactBook
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_EditContact_Click(object sender, RoutedEventArgs e)
        {
            frame_PageFrame.NavigationService.Navigate(new Uri("/Pages/EditContact.xaml", UriKind.Relative));
        }

        private void btn_AddContact_Click(object sender, RoutedEventArgs e)
        {
            frame_PageFrame.NavigationService.Navigate(new Uri("/Pages/AddContact.xaml", UriKind.Relative));
        }

        private void btn_RemoveContact_Click(object sender, RoutedEventArgs e)
        {
            frame_PageFrame.NavigationService.Navigate(new Uri("/Pages/RemoveContact.xaml", UriKind.Relative));
        }
    }
}
