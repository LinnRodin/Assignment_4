using _04_Addressbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Addressbook.Services
{
    public class AdressBookService
    {
        public List<Contact> ContactList { get; set; } = new List<Contact>();
    }
}
