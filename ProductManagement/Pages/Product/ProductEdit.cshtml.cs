using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagement.Model;

namespace ProductManagement.Pages.Product
{
    public class ProductEditModel : PageModel
    {

        Appdb _db;
        public ProductEditModel()
        {
            _db = new Appdb();
        }

        [BindProperty]
        public ProductModel UserProduct { set; get; }

        public ProductModel Dbproduct { set; get; }


        public IActionResult OnGet(int Id)
        {
            Dbproduct = _db.products.FirstOrDefault(p => p.Id == Id);

            UserProduct = Dbproduct;

            return Page();

        }

        public IActionResult OnPost()
        {
            Dbproduct = _db.products.FirstOrDefault(p => p.Id == UserProduct.Id);

            Dbproduct.ProductName = UserProduct.ProductName;
            Dbproduct.ProductDiscription = UserProduct.ProductDiscription;
            Dbproduct.Price = UserProduct.Price;
            Dbproduct.ProductQuantity = UserProduct.ProductQuantity;
            _db.SaveChanges();

            return RedirectToPage("/Product/ProductListing");
        }
    }
}
