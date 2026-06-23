class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalPrice { get; set; }


    public Order(int orderId, string customerName, double totalPrice)
    {
        OrderId = orderId;
        CustomerName = customerName;
        TotalPrice = totalPrice;
    }


    public void Display()
    {
        Console.WriteLine(
            $"Order ID: {OrderId}, Customer: {CustomerName}, Total Price: {TotalPrice}"
        );
    }
}