using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InLab_Project.Pages.Admin
{

    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string name { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPostLogout() {
            return RedirectToPage("/Index");
        }
    }
}
