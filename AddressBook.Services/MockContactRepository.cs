using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookMVC.Models
{
    public class MockContactRepository : IContactRepository
    {
        private List<Contact> _contactList;
        public MockContactRepository()
        {
            _contactList = new List<Contact>()
            {
                new Contact() { Id = 1, Name = "Vijay", Email = "vijay@gmail.com", Mobile = 7070707070, Landline = 987645, Address = "12, South street", Website = "vijay.com" },
                new Contact() { Id = 2, Name = "Shashi", Email = "shahi@gmail.com", Mobile = 8070707070, Landline = 987645, Address = "12, South street", Website = "vijay.com" },
                new Contact() { Id = 3, Name = "Ram", Email = "ram@gmail.com", Mobile = 9070707070, Landline = 987645, Address = "12, South street", Website = "vijay.com" },
                new Contact() { Id = 4, Name = "Sham", Email = "sham@gmail.com", Mobile = 6070707070, Landline = 987645, Address = "12, South street", Website = "vijay.com" }
            };
        }
        public IEnumerable<Contact> GetAllContacts()
        {
            return _contactList;
        }

        public Contact GetContact(int id)
        {
            return _contactList.FirstOrDefault(c => c.Id == id);
        }
        public Contact AddContact(Contact newContact)
        {
            newContact.Id = _contactList.Max(c => c.Id) + 1;
            Contact contact = new Contact();
            contact.Id = newContact.Id;
            contact.Name = newContact.Name;
            contact.Email = newContact.Email;
            contact.Mobile = newContact.Mobile;
            contact.Landline = newContact.Landline;
            contact.Website = newContact.Website;
            contact.Address = newContact.Address;

            _contactList.Add(contact);
            Console.WriteLine(_contactList);
            return contact;
        }
        public Contact Delete(int id)
        {
            Contact contactToDelete = _contactList.FirstOrDefault(c => c.Id == id);
            if (contactToDelete != null)
            {
                _contactList.Remove(contactToDelete);
            }
            return contactToDelete;
        }
        public Contact Update(Contact updateContact)
        {
            Contact contact = _contactList.FirstOrDefault(c => c.Id == updateContact.Id);
            if (contact != null)
            {
                contact.Name = updateContact.Name;
                contact.Email = updateContact.Email;
                contact.Mobile = updateContact.Mobile;
                contact.Landline = updateContact.Landline;
                contact.Website = updateContact.Website;
                contact.Address = updateContact.Address;
            }
            return contact;
        }
    }
}
