using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Create Address
        Address address1 = new Address("123 Testing Ln", "Test City", "Hawaii", "USA");
        Address address2 = new Address("456 Coming Back", "Kioni", "Moorea", "French Polynesia");

        Customer customer1 = new Customer("Customer 1", address1);
        Customer customer2 = new Customer("Customer 2", address2);

        Product product1 = new Product("milk", 1, 3.49, 2);
        Product product2 = new Product("eggs", 2, 13.29, 1);
        Product product3 = new Product("bread", 3, 2.79, 1);

        List<Product> products1 = new List<Product>();
        products1.Add(product1);
        products1.Add(product3);

        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product2);
        products2.Add(product1);

        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("\nPackaging Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("\nPackaging Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.GetTotalCost()}");
    }
}