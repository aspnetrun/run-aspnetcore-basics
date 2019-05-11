using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetRunBasicRealWorld.Data;
using AspNetRunBasicRealWorld.Entities;

namespace AspNetRunBasicRealWorld.Repositories
{
    public class ContactRepository : IContactRepository
    {
        protected readonly AspnetRunContext _dbContext;

        public ContactRepository(AspnetRunContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<Contact> SendMessage(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            await _dbContext.SaveChangesAsync();
            return contact;
        }

        public async Task<Contact> Subscribe(string address)
        {
            var newContact = new Contact();
            newContact.Email = address;
            newContact.Message = address;
            newContact.Name = address;

            return newContact;
        }
    }
}
