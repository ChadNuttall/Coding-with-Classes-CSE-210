public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private Address _address;
    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _address = address;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            double productPrice = product.CalculatePrice();
            total += productPrice;
        }
        total = Math.Round((total + GetShippingCost()), 2);
        return total;
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Ship To:");
        _customer.DisplayCustomer();
    }
    public void DisplayPackingLabel()
    {   
        Console.WriteLine("Packing Label");
        foreach (Product product in _products)
        {
            product.DisplayProductDetails();
        }
        
    }
    public double GetShippingCost()
    {
        double shippingCost;
        if (_address.GetCountry() == "USA")
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }

    public void DisplayCost(double totalCost)
    {
        Console.WriteLine($"Total: ${totalCost}");
    }
}