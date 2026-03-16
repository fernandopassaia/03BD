namespace EventDriven;

public class InvoiceService
{
    public void HandleOrderCreated(object sender, OrderCreatedEventArgs e)
    {
        Console.WriteLine($"Nota fiscal gerada para o pedido {e.OrderId}");
    }
}