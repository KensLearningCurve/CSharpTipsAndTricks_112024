using Logic;
using Microsoft.EntityFrameworkCore;

namespace SQLAndLINQwithEF;

public class ProductContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
}
