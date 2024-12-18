using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InLab_Project.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		[BindProperty(SupportsGet = true)]
		public Models.User USER1 { get; set; }
		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public IActionResult OnGet()
		{
			if (!string.IsNullOrEmpty(HttpContext.Session.GetString("name")))
			{
				 USER1.name= HttpContext.Session.GetString("name")!;
			}
			return Page();
		}

		public IActionResult OnPostLogin()
		{
			return RedirectToPage("/LogIn");
		}

        public IActionResult OnPostLogout()
        {
            HttpContext.Session.SetString("name", "");

            return Page();
        }
    }
}
