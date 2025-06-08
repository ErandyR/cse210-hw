

using System.Security.Cryptography.X509Certificates;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }
    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        if (_customer.CustomerInUSA() == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Product name:{product.GetName()}\nProduct ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress().GetFullAddress()}";
        return shippingLabel;
    }
}