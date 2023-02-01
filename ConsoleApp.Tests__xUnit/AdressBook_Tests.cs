using _04_Addressbook.Models;
using _04_Addressbook.Services;

namespace ConsoleApp.Tests__xUnit
{
    public class AddressBook_Tests
    {
        public MenuServices addressBook;
        Contact contact;

        public AddressBook_Tests()
        {
            // arrange
            addressBook = new MenuServices();
            contact = new Contact();
        }

        [Fact]
        public void Should_Add_Contact_To_List()
        {
            addressBook.registry.Add(contact);
            addressBook.registry.Add(contact);

            // assert
            Assert.Equal(2, addressBook.registry.Count);

        }


        [Fact]
        public void Should_Remove_Contact_From_List()
        {
            // arrange 
            addressBook.registry.Add(contact);
            addressBook.registry.Add(contact);

            // act
            addressBook.registry.Remove(contact);

            // assert
            Assert.Single(addressBook.registry);
        }
    }
}