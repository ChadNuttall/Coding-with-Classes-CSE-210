public class Product
{
    private string _productName;
    private string _id;
    private  double _price;
    private int _quantity;

    public Product (string productName, string id, double price, int quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        return Math.Round((_price * _quantity),2);
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"{_quantity}: {_productName} ID:{_id} || Total: ${CalculatePrice()}");
    }
}