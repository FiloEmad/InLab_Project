using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace InLab_Project.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        [Required (ErrorMessage ="This field is required")]
        public string name { get; set; }

        [BindProperty(SupportsGet = true)]
        [Required]
        public string pass { get; set; }
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
                HttpContext.Session.SetString("name", name);
                if (name.Contains("a-"))
                {
                    return RedirectToPage("/Index", new { name = this.name });
                }
                else if ((name.Contains("s-")))
                {
                    return RedirectToPage("/Index", new { name = this.name });
                }
                else
                {
                    return Page();
                }
            }
        }
    }
}
