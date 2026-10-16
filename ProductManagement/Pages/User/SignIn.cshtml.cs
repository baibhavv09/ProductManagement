using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagement.Model;

namespace ProductManagement.Pages.User
{
    public class SignInModel : PageModel
    {
        Appdb _db;

        public SignInModel()
        {
            _db = new Appdb();
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var res = _db.user.FirstOrDefault(u => u.Email == Email);
            if (res!=null)
            {
                if (res.Password == Password)
                {
                   return RedirectToPage("/Listing");
                }
                else
                {
                    Message = "Incorrect password";
                }
             
            }
            else
            {
                Message = "Incorrect Email & password";
            }
            return Page();
        }
    }
}
