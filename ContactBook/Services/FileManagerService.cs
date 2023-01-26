using ContactBook.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Services
{
    public class FileManagerService
    {
        private string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
        private List<Contact> contacts;

        public FileManagerService()
        {
            ReadFromFile();
        }

        public void ReadFromFile()
        {
            try
            {
                using var sr = new StreamReader(filePath);
                contacts = JsonConvert.DeserializeObject<List<Contact>>(sr.ReadToEnd())!;
            }
            catch { contacts = new List<Contact>(); }
        }

        public void SaveToFile()
        {


            using var sw = new StreamWriter(filePath);
            sw.WriteLine(JsonConvert.SerializeObject(contacts));

        }

        public void AddToList(Contact content)
        {
            contacts.Add(content);
            SaveToFile();
        }

        public void RemoveFromList(Contact content) 
        {
            contacts.Remove(content);
            SaveToFile();
        }


        public ObservableCollection<Contact> Content()
        { 
            var items = new ObservableCollection<Contact>();
            foreach (Contact contact in contacts)
                items.Add(contact);
            return items;
        
        }
    }
}
