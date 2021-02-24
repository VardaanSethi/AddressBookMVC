using AddressBookMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookMVC.Controllers
{
    public class EditController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public Contact contact { get; set; }
        public EditController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        [HttpGet]
        public IActionResult Index(int id)
        {
            contact = _contactRepository.GetContact(id);
            ViewBag.contact = _contactRepository.GetAllContacts();
            return View(contact);
        }
        [HttpPost]
        public IActionResult Index(Contact updatedContact)
        {
            IEnumerable<Contact> contacts = _contactRepository.GetAllContacts();
            if (ModelState.IsValid)
            {
                ViewBag.contact = contacts;
                _contactRepository.Update(updatedContact);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.contact = contacts;
            return View(contact);
        }
    }
}
