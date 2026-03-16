namespace EventDriven;

public class EmailService
{
    public void HandleOrderCreated(object sender, OrderCreatedEventArgs e)
    {
        Console.WriteLine($"Email enviado para {e.CustomerEmail} sobre o pedido {e.OrderId}");
    }
}