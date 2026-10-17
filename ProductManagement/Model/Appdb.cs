using Microsoft.EntityFrameworkCore;

namespace ProductManagement.Model
{
    public class Appdb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=VAIBHAV;Initial Catalog=ProductManagement;Integrated Security=true;TrustServerCertificate=true;");
        }

        public DbSet<UserModel> user { get; set; }

        public DbSet<ProductModel> products { get; set; }


    }
}