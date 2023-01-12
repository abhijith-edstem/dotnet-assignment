// Shopping Cart

ShoppingCart cart = new ShoppingCart();
{
    try
    {
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Enter the name of item " + (i + 1) + ": ");
            string name = Console.ReadLine();

            Console.Write("Enter the quantity of item " + (i + 1) + ": ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter the price of item " + (i + 1) + ": ");
            double price = double.Parse(Console.ReadLine());
            cart.AddItem(name, quantity, price);
        }

        Order order = new Order();
        double totalPrice = cart.TotalBill();
        Console.WriteLine($"Total price of the order is: {order.TotalPrice(totalPrice)}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error faced : {ex.Message}");
    }

}
