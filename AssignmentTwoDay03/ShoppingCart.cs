
class ShoppingCart
{
    public readonly List<ShoppingCartEntry> _entries = new List<ShoppingCartEntry>();
    public void AddItem(string name, int quantity, double price)
    {
        ShoppingCartEntry entry = new ShoppingCartEntry();
        entry.Name = name;
        entry.Quantity = quantity;
        entry.Price = price;
        _entries.Add(entry);
    }
    public double TotalBill()
    {
        double total = 0.0;
        foreach (var item in _entries)
        {
            total += item.Price * item.Quantity;
        }
        return total;
    }
}