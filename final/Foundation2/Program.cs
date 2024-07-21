using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Cheese", "01356", 5, 2);
        Product product2 = new Product("Bread", "01378", 10, 1);
        Product product3 = new Product("Mayo", "01390", 4, 6);
        Product product4 = new Product("Ham", "01321", 6, 8);
        Product product5 = new Product("Peperroni", "01374", 8, 3);
        Product product6 = new Product("Bacon", "01329", 9, 7);

        Address address1 = new Address("Wallaby P Sherman", "Sydney", "New South Wales", "Australia");
        Address address2 = new Address("4374 S Main street", "Murray", "Utah", "USA");

        Customer customer1 = new Customer("Logan", address1);
        Customer customer2 = new Customer("Alejandro", address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProducts(product1);
        order1.AddProducts(product2);
        order1.AddProducts(product3);
        order1.AddProducts(product5);

        order2.AddProducts(product1);
        order2.AddProducts(product2);
        order2.AddProducts(product4);
        order2.AddProducts(product6);

        order1.PackingLabel();
        order1.ShippingLabel();
        int totalPrice1 = order1.CalculateTotalCost();
        Console.WriteLine($"The total price is: ${totalPrice1}.");

        Console.WriteLine();

        order2.PackingLabel();
        order2.ShippingLabel();
        int totalPrice2 = order2.CalculateTotalCost();
        Console.WriteLine($"The total price is: ${totalPrice2}.");
    }
}