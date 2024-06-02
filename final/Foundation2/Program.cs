using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Foundation2 World!");
//     }
// }

public class Program
{
    public static void Main(string[] args)
    {
        // Create addresses
        Console.WriteLine();
        Address address1 = new Address("120 Main St", "Any towns", "NY", "USA");
        Address address2 = new Address("546 Elm St", "Other towns", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Mike Jean", address1);
        Customer customer2 = new Customer("Evens Peter", address2);

        // Create products
        Product product1 = new Product("Laptop", "A001", 999.99m, 1);
        Product product2 = new Product("Mouse", "A002", 25.50m, 2);
        Product product3 = new Product("Keyboard", "A003", 75.00m, 1);
        Product product4 = new Product("Monitor", "A004", 200.00m, 2);

        // Create orders and add products to them
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    public static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}\n");

        Console.WriteLine();
        Console.Beep();
    }
}
