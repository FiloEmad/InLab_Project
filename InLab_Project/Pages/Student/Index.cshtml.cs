using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InLab_Project.Pages.Student
{

    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string name { get; set; }
        public IActionResult OnGet()
        {
            if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString("name")))
            {
                return RedirectToPage("/LogIn");
            }
            else
            {
                name = HttpContext.Session.GetString("name");
                return Page();
            }
        }
        public IActionResult OnPostLogout()
        {
            return RedirectToPage("/Index");
        }
    }
}
