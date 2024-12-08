public class Product
{
    private string _productName;
    private string _code;
    private decimal _unitPrice;
    private int _count;

    public Product(string productName, string code, decimal unitPrice, int count)
    {
        _productName = productName;
        _code = code;
        _unitPrice = unitPrice;
        _count = count;
    }

    public string GetProductName() => _productName;
    public string GetCode() => _code;
    public decimal GetUnitPrice() => _unitPrice;
    public int GetCount() => _count;

    public decimal GetTotalPrice()
    {
        return _unitPrice * _count;
    }
}
