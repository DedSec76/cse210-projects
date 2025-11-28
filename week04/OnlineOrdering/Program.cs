using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Av. 28 de Julio", "Cerro Camote", "Huarochiri", "Peru");
        Address a2 = new Address("Street 4th", "Utah", "California", "Usa");

        Customer c1 = new Customer("Aldair Rutte", a1);
        Customer c2 = new Customer("Billie Loomis", a2);

        Product p1 = new Product("Leche gloria", "001", 10, 1);
        Product p2 = new Product("Azucar", "011", 20, 1);
        Product p3 = new Product("Chocolate", "045x", 30, 1);
        Product p4 = new Product("Gelatina", "015", 2.50, 5);

        // Order Objects
        Order o1 = new Order(c1);
        Order o2 = new Order(c2);

        // Adding Products
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);

        o2.AddProduct(p4);
        o2.AddProduct(p3);
        o2.AddProduct(p1);

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine("Total Cost: $"+o1.CalculateTotalCost());

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine("Total Cost: $"+o2.CalculateTotalCost());
    }
}