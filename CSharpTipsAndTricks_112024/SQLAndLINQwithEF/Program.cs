using Microsoft.EntityFrameworkCore;
using SQLAndLINQwithEF;

var options = new DbContextOptionsBuilder<ProductContext>()
           .UseInMemoryDatabase(databaseName: "InMemoryProductDatabase")
           .Options;


using (var context = new ProductContext(options))
{
    var products = context.Products
            .FromSql($"SELECT * FROM Products WHERE Title like '%su%'")
            .Where(x => x.Available)
            .ToList();
}

