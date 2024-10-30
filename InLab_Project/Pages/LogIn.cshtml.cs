using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InLab_Project.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string name { get; set; }
        [BindProperty(SupportsGet = true)]
        public string pass { get; set; }
        public void OnGet()
        {
        }

        public  IActionResult OnPost() {
            if(name.Contains("a-"))
            {
                return RedirectToPage("/Admin/Index", new { name = this.name });
            }
            else
            {
                return Page();
            }
        }
    }
}
