using System;
using System.Net.Http.Headers;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProducts(Product product)
    {
        _products.Add(product);
    }

    public int ShippingCost()
    {
        if (_customer.USAorNot())
        {
            return 5;
        }
        else return 35;
    }

    public int CalculateTotalCost()
    {
        int totalCost = 0;
        foreach (Product product in _products)
        {
            int cost = product.TotalCost();
            totalCost += cost;
        }
        int shippingCost = ShippingCost();
        totalCost += shippingCost;
        return totalCost;
    }

    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            string name = product.GetName();
            string id = product.GetProductId();
            Console.WriteLine($"Product name: {name}, id: {id}.");
        }
    }  

    public void ShippingLabel()
    {
        _customer.GetAddress();
    } 
}