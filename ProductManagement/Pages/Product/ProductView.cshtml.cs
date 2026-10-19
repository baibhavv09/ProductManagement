using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagement.Model;

namespace ProductManagement.Pages.Product
{
    public class ProductViewModel : PageModel
    {
        Appdb _db;
        public ProductViewModel()
        {
            _db = new Appdb();
        }


        public ProductModel? Product { set; get; }

        public void OnGet(int Id)
        {
            Product = _db.products.FirstOrDefault(p => p.Id == Id);
        }
    }
}
