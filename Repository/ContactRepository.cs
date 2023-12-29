//FICA RESPONSAVEL PELOS MÉTODOS QUE MANIPULAM A TABELA DO BANCO
using ContactRegistrationCourse.Data;
using ContactRegistrationCourse.Interfaces;
using ContactRegistrationCourse.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ContactRegistrationCourse.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly DBContext _dbContext;
        public ContactRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ContactModel AddContact(ContactModel contact)
        {
            _dbContext.Contacts.Add(contact);
            _dbContext.SaveChanges();
            return contact;
        }
        public List<ContactModel> SearchContacts()
        {
            List<ContactModel> contacts = _dbContext.Contacts.ToList();
            return contacts;
        }
        public ContactModel GetContactById(int id)
        {
            ContactModel contact = _dbContext.Contacts.FirstOrDefault(contct => contct.Id == id);
            return contact;
        }
        public ContactModel UpdateContact(ContactModel contact)
        {
            ContactModel editableContact = GetContactById(contact.Id);

            if (editableContact == null) throw new Exception("contact does not exist in the database");

            editableContact.Name = contact.Name;
            editableContact.Email = contact.Email;
            editableContact.Phone = contact.Phone;

            _dbContext.Contacts.Update(editableContact);
            _dbContext.SaveChanges();
            return editableContact;
        }
        public ContactModel DeleteContact(int Id)
        {
            ContactModel deleteableContact = GetContactById(Id);
            if (deleteableContact == null) throw new Exception("contact does not exist in the database");

            _dbContext.Contacts.Remove(deleteableContact);
            _dbContext.SaveChanges();

            return deleteableContact;
        }
    }
}
