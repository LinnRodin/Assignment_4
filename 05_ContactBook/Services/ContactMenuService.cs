using _05_ContactBook.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ContactBook.Services
{
    internal class ContactMenuService
    {
       
        private List<Contact> registry = new List<Contact>();  //privata listor

        private FileManager file = new FileManager();
        public string FilePath { get; set; } = null!;

        public void OptionsMenu()
        {
            try
            {
                registry = JsonConvert.DeserializeObject<List<Contact>>(file.Read(FilePath))!;  //Reads answer and saves in program
            }
            catch { }

            Console.WriteLine("Welcome to the adressbook!");
            Console.WriteLine("1. Add a new contact.");
            Console.WriteLine("2. Show contact.");
            Console.WriteLine("3. Show all contacts.");
            Console.WriteLine("4. Remove contact.");
            Console.WriteLine("Please Enter one of the options above: ");
            var option = Console.ReadLine();                                //Saves the answer



            switch (option)
            {
                case "1": OptionOne(); break;
                case "2": OptionTwo(); break;
                case "3": OptionThree(); break;
                case "4": OptionFour(); break;

            }


        }

        private void OptionOne()    //Add a new contact
        {

            Console.Clear();
            Console.WriteLine("Please enter contact information");

            Contact adressbook = new Contact();
            Console.Write("Please enter Firstname: ");
            adressbook.FirstName = Console.ReadLine() ?? "";
            Console.Write("Please enter Lastname: ");
            adressbook.LastName = Console.ReadLine() ?? "";
            Console.Write("Please enter an email: ");
            adressbook.Email = Console.ReadLine() ?? "";
            Console.Write("Please enter a phonenumber: ");
            adressbook.PhoneNumber = Console.ReadLine() ?? "";
            Console.Write("Please enter a streetname: ");
            adressbook.StreetName = Console.ReadLine() ?? "";
            Console.Write("Please enter a postalcode: ");
            adressbook.PostalCode = Console.ReadLine() ?? "";
            Console.Write("Please enter a city: ");
            adressbook.City = Console.ReadLine() ?? "";


            registry.Add(adressbook);

            file.Save(FilePath, JsonConvert.SerializeObject(registry));  // Saves the answer on the desktop in a Json file.
        }



        private void OptionTwo() // Search/find by firstname = find a specific contact
        {

            Console.WriteLine("Enter the firstname of the person you would like to find.");
            string firstName = Console.ReadLine() ?? "";
            Contact adressbook = registry.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower())!;

            if (adressbook == null)
            {

                Console.WriteLine("That contact could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }


            Console.WriteLine("FirstName: " + adressbook.FirstName);
            Console.WriteLine("LastName: " + adressbook.LastName);
            Console.WriteLine("Email: " + adressbook.Email);
            Console.WriteLine("Phonenumber: " + adressbook.PhoneNumber);
            Console.WriteLine("Adress: " + adressbook.StreetName + ", " + adressbook.PostalCode + " " + adressbook.City);
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }



        private void OptionThree()  //Show all contacts
        {
            if (registry.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var adressbook in registry)
            {
                Console.WriteLine("FirstName: " + adressbook.FirstName);
                Console.WriteLine("LastName: " + adressbook.LastName);
                Console.WriteLine("Email: " + adressbook.Email);
                Console.WriteLine("---------------------------------------");

            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }


        private void OptionFour()       //Remove contact
        {
            Console.WriteLine("Enter the firstname of the person you would like to remove.");
            string firstName = Console.ReadLine() ?? "";
            Contact adressbook = registry.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower())!;

            if (adressbook == null)
            {
                Console.WriteLine("That contact could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Are you sure you want to remove this contact from your address book? (Y/N)");
            Console.WriteLine("FirstName: " + adressbook.FirstName);
            Console.WriteLine("LastName: " + adressbook.LastName);
            Console.WriteLine("Email: " + adressbook.Email);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                registry.Remove((Contact)adressbook);
                file.Save(FilePath, JsonConvert.SerializeObject(registry));
                Console.WriteLine("\nContact removed. Press any key to continue.");
                Console.ReadKey();
            }
        }

    }

    
}
