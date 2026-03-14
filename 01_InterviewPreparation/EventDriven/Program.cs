namespace EventDriven;

class Program
{
    static void Main()
    {
        var orderService = new OrderService();

        var emailService = new EmailService();
        var inventoryService = new InventoryService();
        var invoiceService = new InvoiceService();

        // Subscribing to event
        orderService.OrderCreated += emailService.HandleOrderCreated;
        orderService.OrderCreated += inventoryService.HandleOrderCreated;
        orderService.OrderCreated += invoiceService.HandleOrderCreated;

        // Criar pedido
        orderService.CreateOrder(1001, "cliente@email.com");
    }
}



public class OrderCreatedEventArgs : EventArgs
{
    public int OrderId { get; set; }
    public string CustomerEmail { get; set; }
}


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


public class EmailService
{
    public void HandleOrderCreated(object sender, OrderCreatedEventArgs e)
    {
        Console.WriteLine($"Email enviado para {e.CustomerEmail} sobre o pedido {e.OrderId}");
    }
}


public class InventoryService
{
    public void HandleOrderCreated(object sender, OrderCreatedEventArgs e)
    {
        Console.WriteLine($"Estoque atualizado para o pedido {e.OrderId}");
    }
}


public class InvoiceService
{
    public void HandleOrderCreated(object sender, OrderCreatedEventArgs e)
    {
        Console.WriteLine($"Nota fiscal gerada para o pedido {e.OrderId}");
    }
}