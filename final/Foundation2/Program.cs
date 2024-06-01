using System;

class Program
{
    static void Main(string[] args)
    {
        Address testAddress = new Address("Street", "City", "State", "Country");
        Customer testCustomer = new Customer("Name", testAddress);

        Product orderProduct1 = new Product("Product 1", "XXX", 1, 2);
        Product orderProduct2 = new Product("Product 2", "XXX", 1.05, 4);

        Order order = new Order(testCustomer, testAddress);
        order.AddProduct(orderProduct1);
        order.AddProduct(orderProduct2);
        double orderTotal = order.CalculateTotal();

        order.DisplayShippingLabel();
        Console.WriteLine();
        order.DisplayPackingLabel();
        Console.WriteLine();
        order.DisplayCost(orderTotal);
        Console.WriteLine();
    }
}