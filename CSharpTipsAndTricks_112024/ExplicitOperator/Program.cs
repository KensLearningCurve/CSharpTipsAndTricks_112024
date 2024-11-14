using Logic;

Product sugar = ProductList.Products.Single(x => x.Title == "Sugar");
DiscontinuedProduct discontinuedSugar = (DiscontinuedProduct)sugar;

public class DiscontinuedProduct
{
    public string Title { get; set; }
    public int Id { get; set; }


    public static explicit operator DiscontinuedProduct(Product product)
    {
        return new()
        {
            Id = product.Id,
            Title = product.Title,
        };
    }
}