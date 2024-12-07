using System;

public class Program
{
    public static void Main()
    {
        // Creating some sample addresses
        Address addr1 = new Address("321 Oak Ave", "Metropolis", "NY", "USA");
        Address addr2 = new Address("654 Maple Dr", "Vancouver", "BC", "Canada");

        // Creating customers tied to addresses
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Customer cust2 = new Customer("Bob Brown", addr2);

        // Creating product objects
        Product prod1 = new Product("Doodad", "D567", 4.99m, 4);
        Product prod2 = new Product("Widget Pro", "W890", 14.99m, 1);
        Product prod3 = new Product("Gizmo Lite", "G123", 9.99m, 2);

        // Building customer orders
        Order ord1 = new Order(cust1);
        ord1.AddProduct(prod1);
        ord1.AddProduct(prod2);

        Order ord2 = new Order(cust2);
        ord2.AddProduct(prod1);
        ord2.AddProduct(prod3);

        // Output details for each order
        Console.WriteLine("Order Details - 1:");
        Console.WriteLine("Packing Information:");
        Console.WriteLine(ord1.GeneratePackingInfo());
        Console.WriteLine("Shipping Details:");
        Console.WriteLine(ord1.GenerateShippingInfo());
        Console.WriteLine($"Grand Total: ${ord1.ComputeTotal():0.00}\n");

        Console.WriteLine("Order Details - 2:");
        Console.WriteLine("Packing Information:");
        Console.WriteLine(ord2.GeneratePackingInfo());
        Console.WriteLine("Shipping Details:");
        Console.WriteLine(ord2.GenerateShippingInfo());
        Console.WriteLine($"Grand Total: ${ord2.ComputeTotal():0.00}");
    }
}
