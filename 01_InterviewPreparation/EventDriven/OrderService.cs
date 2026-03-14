namespace EventDriven;

public class OrderService
{
    public event EventHandler<OrderCreatedEventArgs> OrderCreated;

    public void CreateOrder(int orderId, string email)
    {
        Console.WriteLine($"Pedido {orderId} criado.");

        OnOrderCreated(orderId, email);
    }

    protected virtual void OnOrderCreated(int orderId, string email)
    {
        // dispara o evento
        OrderCreated?.Invoke(this, new OrderCreatedEventArgs
        {
            OrderId = orderId,
            CustomerEmail = email
        });
    }
}