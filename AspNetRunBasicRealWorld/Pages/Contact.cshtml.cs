using System;
using System.Threading.Tasks;
using AspNetRunBasicRealWorld.Entities;
using AspNetRunBasicRealWorld.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetRunBasicRealWorld.Pages
{
    public class ContactModel : PageModel
    {
        private readonly IContactRepository _contactRepository;

        public ContactModel(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
        }

        [BindProperty]
        public Contact Contact { get; set; }
        public string Message { get; private set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _contactRepository.SendMessage(Contact);
            return RedirectToPage("Confirmation", "Contact");
        }

        public async Task<IActionResult> OnPostSubscribeAsync(string address)
        {
            await _contactRepository.Subscribe(address);
            return RedirectToPage("Confirmation", "Subscribe");
        }
    }
}