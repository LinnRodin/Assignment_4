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


            //fileManagerService.AddToList(new Contact() {tb_FirstName });
            //tb_FirstName = string.Empty;

        }
    }
}
