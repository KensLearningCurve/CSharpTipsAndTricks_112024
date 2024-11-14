

using Logic;

for (int i = 0; i<ProductList.Products.Count; i++)
{
    Console.WriteLine($"Index = {i}, Name = {ProductList.Products[i].Title}");
}

foreach ((int index, Product product) in ProductList.Products.Index())
{
    Console.WriteLine($"Index = {index}, Name = {product.Title}");
}