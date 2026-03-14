namespace EventDriven;

public class InventoryService
{
    public void HandleOrderCreated(object sender, OrderCreatedEventArgs e)
    {
        Console.WriteLine($"Estoque atualizado para o pedido {e.OrderId}");
    }
}