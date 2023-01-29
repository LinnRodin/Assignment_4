using ContactBook.Controls;
using ContactBook.Models;
using ContactBook.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactBook.Pages
{
    
    public partial class MainPageContacts : Page
    {
        private readonly FileManagerService fileManagerService;
        public ObservableCollection<Contact> contacts { get; set; }
        public MainPageContacts()
        {
            InitializeComponent();
            fileManagerService = new FileManagerService();
            contacts = (ObservableCollection<Contact>)fileManagerService.Content();

            lv_Contacts.ItemsSource= contacts;
        }

       

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedContact = lv_Contacts.SelectedItem as Contact;
            if (selectedContact != null)
            {
                selectedContact.FirstName = tb_FirstName.Text;
                selectedContact.LastName = tb_LastName.Text;
                selectedContact.Email = tb_Email.Text;
                selectedContact.PhoneNumber = tb_Phone.Text;
                selectedContact.PostalCode = tb_PostalCode.Text;
                selectedContact.City = tb_City.Text;
                fileManagerService.SaveToFile();
            }

            tb_FirstName.Text = string.Empty;
            tb_LastName.Text = string.Empty;
            tb_Email.Text = string.Empty;
            tb_Phone.Text = string.Empty;
            tb_PostalCode.Text = string.Empty;
            tb_City.Text = string.Empty;

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedContact = lv_Contacts.SelectedItem as Contact;
            if (selectedContact != null)
            {
                fileManagerService.RemoveFromList(selectedContact);
            }
            tb_FirstName.Text = string.Empty;
            tb_LastName.Text = string.Empty;
            tb_Email.Text = string.Empty;
            tb_Phone.Text = string.Empty;
            tb_PostalCode.Text = string.Empty;
            tb_City.Text = string.Empty;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            fileManagerService.SaveToFile();
            MessageBox.Show("Changes saved successfully!");
        }
    }
}
