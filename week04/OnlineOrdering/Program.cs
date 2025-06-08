using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("226 May St", "Needham", "Massachusetts", "USA");
        Customer customer1 = new Customer("Caroline", address1);

        Address address2 = new Address("122 Allende", "Xicohtzinco", "Tlaxcala", "Mexico");
        Customer customer2 = new Customer("Erandy", address2);

        Product product1 = new Product("Bottle", "BT110", 20.50, 1);
        Product product2 = new Product("T-shirt", "TS103", 16.99, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Product product3 = new Product("Socks", "SC009", 11.50, 4);
        Product product4 = new Product("Shampoo", "SP111", 20.50, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine($"Packing Label:\n{order.GetPackingLabel()}");
            Console.WriteLine($"Shipping Label:\n{order.GetShippingLabel()}");
            Console.WriteLine($"Total Price: ${order.GetTotalPrice()}\n");
        }
    }
}