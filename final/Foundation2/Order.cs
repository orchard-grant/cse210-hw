using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> productList;
    private Customer orderCustomer;

    public Order(Customer orderCustomer)
    {
        this.productList = new List<Product>();
        this.orderCustomer = orderCustomer;
    }

    public void AddProduct(Product product)
    {
        productList.Add(product);
    }

    public decimal ComputeTotal()
    {
        decimal subtotal = 0;
        foreach (var product in productList)
        {
            subtotal += product.GetTotalPrice();
        }

        decimal shippingFee = orderCustomer.ResidesInUSA() ? 5 : 30;
        return subtotal + shippingFee;
    }

    public string GeneratePackingInfo()
    {
        StringBuilder packingInfo = new StringBuilder();
        foreach (var product in productList)
        {
            packingInfo.AppendLine($"Item: {product.ProductName}, Code: {product.Code}");
        }
        return packingInfo.ToString();
    }

    public string GenerateShippingInfo()
    {
        return $"Recipient: {orderCustomer.FullName}\nShipping Address: {orderCustomer.HomeAddress}";
    }
}
