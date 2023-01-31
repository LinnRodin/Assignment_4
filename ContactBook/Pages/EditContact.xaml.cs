using ContactBook.Models;
using ContactBook.Services;
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

namespace ContactBook.Pages
{
   
    public partial class EditContact : Page
    {
        private readonly FileManagerService fileManagerService;
        public EditContact()
        {
            InitializeComponent();
            fileManagerService = new FileManagerService();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {


        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
    
}
