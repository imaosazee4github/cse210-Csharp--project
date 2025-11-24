using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering Program\n");

        //------ORDER1------

        Address addr1 =  new Address("123 Go St", "New York", "NY", "USA");
        Customer cus1 = new Customer("Kelvin Smith", addr1);
        Order order1 = new Order(cus1);

        order1.AddProduct(new Product("Laptop", 101, 1200, 1));
        order1.AddProduct(new Product("Mouse", 102, 25, 2));

        //-----ORDER 2-------
        Address addr2 = new Address("45 Zine Road", "Toronto", "ON", "Canada");
        Customer cus2 = new Customer("Mercy James", addr2);
        Order order2 = new Order(cus2);

        order2.AddProduct(new Product("Phone", 201, 800, 1));
        order2.AddProduct(new Product("Charger", 202, 30, 3));

        //Display Results
        DisplayOrder(order1);
        Console.WriteLine("--------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order.GetTotalCost());
        Console.WriteLine();
    }
}