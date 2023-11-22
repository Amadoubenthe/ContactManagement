using ContactManagement.DataAccess.Models;

namespace ContactManagement.BusinessLogic.Interfaces
{
    public interface IContact
    {
        IEnumerable<Contact> GetContacts();
    }
}
