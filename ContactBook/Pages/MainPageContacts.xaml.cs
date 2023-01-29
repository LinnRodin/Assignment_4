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
    
    public partial class MainPageContacts : Page
    {
        private readonly FileManagerService fileManagerService;
        public MainPageContacts()
        {
            InitializeComponent();
            fileManagerService = new FileManagerService();
        }

       

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Contact contactToEdit = new Contact()
            {
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text,
                Email = tb_Email.Text,
                PhoneNumber = tb_Phone.Text,
                PostalCode = tb_PostalCode.Text,
                City = tb_City.Text
            };

            fileManagerService.ContactToEdit(contactToEdit);
            tb_FirstName.Text = string.Empty;

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            fileManagerService.RemoveFromList(new Contact()
            { 
              FirstName = tb_FirstName.Text, 
              LastName = tb_LastName.Text, 
              Email = tb_Email.Text, 
              PhoneNumber = tb_Phone.Text, 
              PostalCode = tb_PostalCode.Text, 
              City = tb_City.Text 
            });
            tb_FirstName.Text = string.Empty;
        }

        private void listbox_MainMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
