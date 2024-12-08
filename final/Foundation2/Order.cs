using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _productList;
    private Customer _orderCustomer;

    public Order(Customer orderCustomer)
    {
        _productList = new List<Product>();
        _orderCustomer = orderCustomer;
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public decimal ComputeTotal()
    {
        decimal subtotal = 0;
        foreach (var product in _productList)
        {
            subtotal += product.GetTotalPrice();
        }

        decimal shippingFee = _orderCustomer.ResidesInUSA() ? 5 : 30;
        return subtotal + shippingFee;
    }

    public string GeneratePackingInfo()
    {
        StringBuilder packingInfo = new StringBuilder();
        foreach (var product in _productList)
        {
            packingInfo.AppendLine($"Item: {product.GetProductName()}, Code: {product.GetCode()}");
        }
        return packingInfo.ToString();
    }

    public string GenerateShippingInfo()
    {
        return $"Recipient: {_orderCustomer.GetFullName()}\nShipping Address: {_orderCustomer.GetHomeAddress()}";
    }
}
