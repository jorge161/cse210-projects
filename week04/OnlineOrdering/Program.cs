using System;

class Program
{
    static void Main(string[] args)
    {   // First order (USA)
        Address address1 = new Address(" calle 18", "blo    uw 18", "SPS", "USA");
        Customer customer1 = new Customer("Jorge Silva", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Play Station 5", "Play161", 500, 1));
        order1.AddProduct(new Product("Control play", "PS3542", 25, 2));

        // Second order (International)
        Address address2 = new Address("BArrio medina", "14 y 13 calle", "Cortes", "Honduras");
        Customer customer2 = new Customer("Cinthia Lopez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Calculadora", "CAT65", 300, 1));
        order2.AddProduct(new Product("Bateria DW20AH", "BAT500", 50, 3));

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
        }
     }
}