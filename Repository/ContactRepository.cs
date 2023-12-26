//FICA RESPONSAVEL PELOS MÉTODOS QUE MANIPULAM A TABELA DO BANCO
using ContactRegistrationCourse.Data;
using ContactRegistrationCourse.Interfaces;
using ContactRegistrationCourse.Models;

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
            var contacts = _dbContext.Contacts.ToList();
            return contacts;
        }
    }
}
