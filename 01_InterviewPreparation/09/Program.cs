using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = new List<int>() { 2, 4, 5, 8, 12, 14, 18, 22, 26, 30, 35, 38, 42, 45, 48, 50, 1, 3, 9, 15, 23, 29, 35, 43, 49 };
List<string> strings = new List<string>() { "Fernando", "Jaqueline", "Huba", "Marina", "Felipe", "Renan" };

var order1items = new List<OrderItem>()
{
  new OrderItem("Product1 Order1", 10, 1),
  new OrderItem("Product2 Order1", 20, 2)
};

var order2items = new List<OrderItem>()
{
  new OrderItem("Product1 Order2", 11, 3),
  new OrderItem("Product2 Order2", 22, 4)
};

var order3items = new List<OrderItem>()
{
  new OrderItem("Product1 Order3", 13, 5),
  new OrderItem("Product2 Order3", 24, 6)
};

var order4items = new List<OrderItem>()
{
  new OrderItem("Product1 Order4", 15, 7),
  new OrderItem("Product2 Order4", 26, 8)
};


var order1 = new Order("Fernando", order1items);
var order2 = new Order("Jaqueline", orderItems2);
var order3 = new Order("Marina", orderItems3);
var order4 = new Order("Felipe", orderItems4);


var result = numbers.Where(n => n > 20);

Console.WriteLine("Resultado:");
foreach (var n in numbers)
{
    Console.WriteLine(n);
}




public class Order()
{
    public Guid OrderId { get; set; }
    public string Customer { get; set; }

    public List<OrderItem> orderItems = new List<OrderItem>();

    public Order(string customer, List<OrderItem> orderItem)
    {
        Customer = customer;
        OrderItem = orderItem;
    }
}

public class OrderItem
{
    public Guid ProductId { get; set; }
    public string Description { get; get; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public OrderItem(string description, decimal price, decimal quantity)
    {
        Description = description;
        Price = price;
        Quantity = quantity;
    }
}