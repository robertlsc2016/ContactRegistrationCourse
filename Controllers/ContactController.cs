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
        public IActionResult Read()
        {
            return View();
        }
        public IActionResult Update(int Id)
        {
            if (ModelState.IsValid)
            {
                var contact = _contactRepository.GetContactById(Id);
                return View(contact);
            }
            return View();
        }
        public IActionResult Delete(int Id)
        {
            if (ModelState.IsValid)
            {
                var contact = _contactRepository.GetContactById(Id);
                return View(contact);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                _contactRepository.AddContact(contact);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult UpdateContact(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                _contactRepository.UpdateContact(contact);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult DeleteContact(int Id)
        {
            var contact = _contactRepository.DeleteContact(Id);
            return RedirectToAction("Index");
        }
    }
}
