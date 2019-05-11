using AspNetRunBasicRealWorld.Entities;
using System.Threading.Tasks;

namespace AspNetRunBasicRealWorld.Repositories
{
    public interface IContactRepository
    {
        Task<Contact> SendMessage(Contact contact);
        Task<Contact> Subscribe(string address);
    }
}
