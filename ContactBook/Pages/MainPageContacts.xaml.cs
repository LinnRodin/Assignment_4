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

       

        public void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedContact = lv_Contacts.SelectedItem as Contact;
            if (selectedContact != null)
            {
                var result = MessageBox.Show("Are you sure you want to make changes to this contact?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    selectedContact.FirstName = tb_FirstName.Text;
                    selectedContact.LastName = tb_LastName.Text;
                    selectedContact.Email = tb_Email.Text;
                    selectedContact.PhoneNumber = tb_Phone.Text;
                    selectedContact.PostalCode = tb_PostalCode.Text;
                    selectedContact.City = tb_City.Text;
                    fileManagerService.SaveToFile();

                    MessageBox.Show("Changes saved successfully!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to edit.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedContact = lv_Contacts.SelectedItem as Contact;
            if (selectedContact != null)
            {
                var result = MessageBox.Show("Are you sure you want to delete this contact?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    fileManagerService.RemoveFromList(selectedContact);
                    lv_Contacts.Items.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Do you want to save the changes?", "Confirm", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                fileManagerService.SaveToFile();
                MessageBox.Show("Changes saved successfully!");
            }
        }
    }
}
