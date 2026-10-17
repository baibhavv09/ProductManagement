using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagement.Model;

namespace ProductManagement.Pages.Product
{
    public class ProductListingModel : PageModel
    {
        Appdb _db;

        public ProductListingModel()
        {
            _db = new Appdb();
        }

        public List<ProductModel> Products { get; set; } = new List<ProductModel>();

        public void OnGet()
        {
            Products = _db.products.ToList();
        }


    }
}
