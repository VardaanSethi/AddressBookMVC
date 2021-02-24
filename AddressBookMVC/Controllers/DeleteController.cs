using AddressBookMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookMVC.Controllers
{
    public class DeleteController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public DeleteController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public Contact contact { get; set; }
        [HttpGet]
        public IActionResult Index(int id)
        {
            _contactRepository.Delete(id);
            return RedirectToAction("Index", "Home");
        }
    }
}