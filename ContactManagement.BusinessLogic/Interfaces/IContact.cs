﻿using ContactManagement.DataAccess.Models;

namespace ContactManagement.BusinessLogic.Interfaces
{
    public interface IContact
    {
        IEnumerable<Contact> GetContacts();
        Task<Contact> AddContactsAsync(ContactRequest contactRequest);
        Task<Contact> UpdateContactsAsync(Guid id, UpdateContactRequest updateContactRequest);
    }
}
