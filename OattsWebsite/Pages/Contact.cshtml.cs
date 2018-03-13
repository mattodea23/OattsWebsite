using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OattsWebsite.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Get in touch with Oatts!";
        }
    }
}
