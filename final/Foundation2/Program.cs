using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main St",
            "Boise",
            "ID",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Keyboard", "A101", 30, 1));
        order1.AddProduct(new Product("Mouse", "A102", 20, 2));
        order1.AddProduct(new Product("Monitor", "A103", 150, 1));


        Address address2 = new Address(
            "55 King Street",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer(
            "Jane Doe",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Headphones", "B201", 80, 1));
        order2.AddProduct(new Product("Webcam", "B202", 60, 1));


        Console.WriteLine("ORDER 1");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.WriteLine();


        Console.WriteLine("ORDER 2");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}