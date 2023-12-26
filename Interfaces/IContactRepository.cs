using ContactRegistrationCourse.Models;

namespace ContactRegistrationCourse.Interfaces
{
    public interface IContactRepository
    {
        List<ContactModel> SearchContacts();
        ContactModel AddContact(ContactModel contact);
    }
}
