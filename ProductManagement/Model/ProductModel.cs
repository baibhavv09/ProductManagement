using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Model
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        public string ProductDiscription { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; } 

        [Required]
        public int ProductQuantity { get; set; }
    }
}

