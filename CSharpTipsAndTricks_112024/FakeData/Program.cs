using Logic;
using Bogus;

var products = new ProductGenerator().Generate(10);

foreach (var product in products)
{
    Console.WriteLine($"The product {product.Title} has a stock of {product.Stock}");
}


class ProductGenerator: Faker<Product>
{
    public ProductGenerator()
    {
        var titles = new string[] { "Laptop", "Smartphone", "Tablet", "Headphones", "Monitor" };

        UseSeed(10)
            .RuleFor(x => x.Title, f => f.PickRandom(titles))
            .RuleFor(x => x.Stock, f => f.Random.Int(0, 100))
            .RuleFor(x => x.Available, f => f.Random.Bool())
            .RuleFor(x => x.Status, f => f.PickRandom<Status>())
            .RuleFor(x => x.Id, f => f.Random.Int());
    }
}