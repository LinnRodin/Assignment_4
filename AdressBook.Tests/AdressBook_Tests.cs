using _04_Addressbook.Models;
using _04_Addressbook.Services;

namespace AdressBook.Tests
{
    [TestClass]
    public class AdressBook_Tests
    {

        [TestMethod]
        public void Should_Add_Contact_To_List()
        {
            AdressBookService adressBook = new AdressBookService();
            
            Contact contact = new Contact();

            adressBook.ContactList.Add(contact);

            Assert.AreEqual(1, adressBook.ContactList.Count);

        }

        [TestMethod]
        public void Should_Remove_Contact_From_List()
        {
            // arrange
            AdressBookService addressBook = new AdressBookService();
            
            Contact contact = new Contact();
            addressBook.ContactList.Add(contact);

            // act
            addressBook.ContactList.Remove(contact);

            // assert
            Assert.AreEqual(0, addressBook.ContactList.Count);
        }
    }
}
