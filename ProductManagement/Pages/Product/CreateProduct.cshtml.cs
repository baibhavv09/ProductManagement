using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagement.Model;

namespace ProductManagement.Pages.Product
{
    public class CreateProductModel : PageModel
    {
        Appdb _db;

        public CreateProductModel()
        {
            _db = new Appdb();
        }

        [BindProperty]
        public ProductModel Product { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _db.products.Add(Product);
            _db.SaveChanges();
            return RedirectToPage("/Product/ProductListing");
        }
    }
}
