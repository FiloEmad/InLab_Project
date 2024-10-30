using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace InLab_Project.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty(SupportsGet = true)]
        [Required]
        public string name { get; set; }

        [BindProperty(SupportsGet = true)]
        [Required]
        public string pass { get; set; }
        public void OnGet()
        {

        }

        public  IActionResult OnPost() {

            if(!string.IsNullOrEmpty(HttpContext.Session.GetString("name")))
            {
                return Page();
            }
            else
            {
                HttpContext.Session.SetString("name", name);
                if (name.Contains("a-"))
                {
                    return RedirectToPage("/Admin/Index", new { name = this.name });
                }
                else if ((name.Contains("s-")))
                {
                    return RedirectToPage("/Student/Index", new { name = this.name });
                }
                else
                {
                    return Page();
                }
            }
        }
    }
}
