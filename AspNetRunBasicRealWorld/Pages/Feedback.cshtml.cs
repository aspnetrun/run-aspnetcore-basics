using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetRunBasicRealWorld.Pages
{
    public class FeedbackModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }
}