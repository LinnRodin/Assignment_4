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
                 //Denna sida är ENDAST uppbyggd visuellt för att visa att man även kunde använt denna designen och navigerat hit via huvudsidan för att även editera härifrån eller i tilägg. 
                 //Nu valde jag att göra allt ifrån huvudsidan. 
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
            //Här kunde vi fortsatt såklart och byggt upp kod för att editera även på en enskild sida. 

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            //Här kunde vi fortsatt såklart och byggt upp kod för att avbryta ett val och gå tillbaka till en sida/sidan om vi ville ha designen på det sättet och inte på en huvudsida. 
        }
    }
    
}
