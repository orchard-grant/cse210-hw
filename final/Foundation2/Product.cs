public class Product
{
    private string productName;
    private string code;
    private decimal unitPrice;
    private int count;

    public Product(string productName, string code, decimal unitPrice, int count)
    {
        this.productName = productName;
        this.code = code;
        this.unitPrice = unitPrice;
        this.count = count;
    }

    public string ProductName => productName;
    public string Code => code;
    public decimal UnitPrice => unitPrice;
    public int Count => count;

    public decimal GetTotalPrice()
    {
        return unitPrice * count;
    }
}
