using AddressBookMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookMVC.Controllers
{
    public class AddController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public Contact contact { get; set; }
        public AddController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public IActionResult Index()
        {
            ViewBag.contact = _contactRepository.GetAllContacts();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid) { 
                _contactRepository.AddContact(contact);
                ViewBag.contact = _contactRepository.GetAllContacts();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.contact = _contactRepository.GetAllContacts();
            return View();
        }
    }
}
