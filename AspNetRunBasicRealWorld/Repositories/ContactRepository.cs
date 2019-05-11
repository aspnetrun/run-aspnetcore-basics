using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetRunBasicRealWorld.Entities;

namespace AspNetRunBasicRealWorld.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public Task<Contact> SendMessage(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> Subscribe(string address)
        {
            throw new NotImplementedException();
        }
    }
}
