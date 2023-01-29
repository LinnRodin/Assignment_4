using ContactBook.Models;
using ContactBook.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
    
    public partial class AddContact : Page
    {
        private readonly FileManagerService fileManagerService;

        public AddContact()
        {
            InitializeComponent();
            fileManagerService = new FileManagerService();

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {


            fileManagerService.AddToList(new Contact() 
            {
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text, 
                Email = tb_Email.Text, 
                PhoneNumber = tb_Phone.Text, 
                PostalCode = tb_PostalCode.Text, 
                City = tb_City.Text 
            });
                tb_FirstName.Text = string.Empty;
                tb_LastName.Text = string.Empty;
                tb_Email.Text = string.Empty;
                tb_Phone.Text = string.Empty;
                tb_PostalCode.Text = string.Empty;
                tb_City.Text = string.Empty;
        }
    }
}
