using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagement.Model;

namespace ProductManagement.Pages.User
{
    public class SignUpModel : PageModel
    {
        Appdb _db;
        public SignUpModel()
        {
            _db = new Appdb();
        }

        [BindProperty]
        
        public UserModel User { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            _db.user.Add(User);
            _db.SaveChanges();
            return RedirectToPage("/SignIn");
        }
    }
}
