class Order
{
    private double _tax = 0.02;
    public double TotalPrice(double addedPrice)
    {
        double totalPrice = addedPrice + addedPrice * _tax;
        return totalPrice;
    }
}