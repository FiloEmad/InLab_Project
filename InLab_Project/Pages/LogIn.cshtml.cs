using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace InLab_Project.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        [Required (ErrorMessage ="This field is required")]
        public Models.User USER2 { get; set; }

        
        
        public IActionResult OnGet()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("name")))
            {
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }

        public  IActionResult OnPost() {
            if (!ModelState.IsValid) { return Page(); }
            if(!string.IsNullOrEmpty(HttpContext.Session.GetString("name")))
            {
                return Page();
            }
            else
            {
                HttpContext.Session.SetString("name", USER2.name);
                HttpContext.Session.SetString("PASS", USER2.password);
                if (USER2.name.Contains("a-"))
                {
                    return RedirectToPage("/Index", new { USER1 = this.USER2 });
                }
                else if ((USER2.name.Contains("s-")))
                {
                    return RedirectToPage("/Index", new { USER1 = this.USER2});
                }
                else
                {
                    return Page();
                }
            }
        }
    }
}
