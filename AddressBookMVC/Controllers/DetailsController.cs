using AddressBookMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookMVC.Controllers
{
    public class DetailsController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public DetailsController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public IActionResult Index(int id)
        {
            Contact contact = _contactRepository.GetContact(id);
            ViewBag.contact = _contactRepository.GetAllContacts();
            return View(contact);
        }
    }
}
