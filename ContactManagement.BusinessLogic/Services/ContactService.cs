
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

        public async Task<Contact> AddContactsAsync(ContactRequest contactRequest)
        {
            Contact contact = new Contact()
            {
                Id = Guid.NewGuid(),
                Name = contactRequest.Name,
                Email = contactRequest.Email,
                Address = contactRequest.Address,
                Phone = contactRequest.Phone,
                CreatedAt = DateTime.UtcNow,
            };

            await _DbContext.Contacts.AddAsync(contact);
            await _DbContext.SaveChangesAsync();

            return contact;
        }

        public async Task<Contact> UpdateContactsAsync(Guid id, UpdateContactRequest updateContactRequest)
        {
            var contact = await _DbContext.Contacts.FindAsync(id);

            if (contact == null)
            {
                return null;
            }

            contact.Name = updateContactRequest.Name;
            contact.Email = updateContactRequest.Email;
            contact.Address = updateContactRequest.Address;
            contact.Phone = updateContactRequest.Phone;

            await _DbContext.SaveChangesAsync();

            return contact;
            
        }
    }
}
