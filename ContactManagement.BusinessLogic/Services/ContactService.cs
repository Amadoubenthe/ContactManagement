
using ContactManagement.BusinessLogic.Interfaces;
using ContactManagement.DataAccess.Data;
using ContactManagement.DataAccess.Models;

namespace ContactManagement.BusinessLogic.Services
{
    public class ContactService: IContact
    {
        public readonly ContactManagementDbContext _DbContext;
        public ContactService(ContactManagementDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _DbContext.Contacts.ToList();
        }
    }
}
