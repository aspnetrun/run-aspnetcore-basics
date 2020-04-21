using System.Threading.Tasks;
using AspnetRunBasics.Entities;

namespace AspnetRunBasics.Repositories.Interfaces
{
    public interface IContactRepository
    {
        Task<Contact> SendMessage(Contact contact);
        Task<Contact> Subscribe(string address);
    }
}
