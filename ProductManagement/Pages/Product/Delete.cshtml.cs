using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagement.Model;

namespace ProductManagement.Pages.Product
{
    public class DeleteModel : PageModel
    {
        Appdb _db;
        public DeleteModel()
        {
            _db = new Appdb();
        }

        public ProductModel product { get; set; }

        public IActionResult OnGet(int Id)
        {
            product = _db.products.FirstOrDefault(p => p.Id == Id);
            _db.products.Remove(product);
            _db.SaveChanges();
            return RedirectToPage("/Product/ProductListing");
        }
    }
}
