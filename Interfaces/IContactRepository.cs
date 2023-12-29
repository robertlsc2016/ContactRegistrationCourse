using ContactRegistrationCourse.Models;

namespace ContactRegistrationCourse.Interfaces
{
    public interface IContactRepository
    {
        ContactModel GetContactById(int id);
        List<ContactModel> SearchContacts();
        ContactModel AddContact(ContactModel contact);
        ContactModel UpdateContact(ContactModel contact);
        ContactModel DeleteContact(int Id);
    }
}
