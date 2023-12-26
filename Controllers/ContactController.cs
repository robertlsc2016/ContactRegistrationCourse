//FICA RESPONSPÁVEL PELAS REQUISIÇÕES
using ContactRegistrationCourse.Interfaces;
using ContactRegistrationCourse.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactRegistrationCourse.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            List<ContactModel> contacts = _contactRepository.SearchContacts();
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(ContactModel contact)
        {
            _contactRepository.AddContact(contact);
            return RedirectToAction("Index");

        }

        public IActionResult Read()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
