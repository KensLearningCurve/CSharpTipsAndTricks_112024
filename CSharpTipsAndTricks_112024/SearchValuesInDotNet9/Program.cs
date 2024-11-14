using Logic;
using System.Buffers;


string[] productTitles = ProductList.Products.Select(x => x.Title).ToArray();

SearchValues<string> svProducts = SearchValues.Create(productTitles, StringComparison.OrdinalIgnoreCase);

IEnumerable<Product> found = ProductList.Products
    .Where(x => svProducts.Contains(x.Title));
