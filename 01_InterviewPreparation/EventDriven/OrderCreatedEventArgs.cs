namespace EventDriven;

public class OrderCreatedEventArgs : EventArgs
{
    public int OrderId { get; set; }
    public string CustomerEmail { get; set; }
}