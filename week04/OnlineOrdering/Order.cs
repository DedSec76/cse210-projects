

using System.ComponentModel.Design.Serialization;

public class Order
{
    public List<Product> _products = new List<Product>();
    public Customer _customer;

    //Constructors
    public Order(Customer customer)
    {
        _customer = customer;
    }
    //Methods
    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }
    public double CalculateTotalCost()
    {
        double totalpay = 0;

        foreach (Product p in _products)
        {
            totalpay += p.GetTotalCost();
        }

        if (!_customer.LivesInUsa())
        {
            totalpay += 35;
        } else
        {
            totalpay += 5;
        }
        return totalpay;
    }

    public string GetPackingLabel()
    {
        string result = "";
        foreach (Product p in _products)
        {
            result += $"\n{p.GetName()} - ID: {p.GetProductId()}";
        }
        return $"\nPacking Label: {result}\n";
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customer.GetName()}\n {_customer.GetAddress().GetFullAddress()}";
    }
}