using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookMVC.Models
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAllContacts();
        Contact GetContact(int id);
        Contact AddContact(Contact newContact);
        Contact Update(Contact updateContact);
        Contact Delete(int id);
    }
}
