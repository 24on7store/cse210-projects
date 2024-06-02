public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost
        totalCost += _customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping To:\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}
