using CsBases.Fundamentals;

public class LabelService : ILabelService
{
    public string GenerateLabel(Product product)
    {
        return $"{product.Name} - Price: {product.Price} - Codigo: {product.GetType().Name}-{product.GetHashCode()}";
    }
}