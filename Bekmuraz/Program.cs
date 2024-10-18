using System;
public class Order
{

    public string Dish { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }

    public Order(string dish, int quantity, int price)
    {
        Dish = dish;
        Quantity = quantity;
        Price = price;
    }

    public int CalculateTotalCost()
    {
        return Quantity * Price;
    }

    public void DisplayOrderInfo()
    {
        Console.WriteLine($"Хавчик: {Dish}");
        Console.WriteLine($"Количество: {Quantity}");
        Console.WriteLine($"Цена: {Price:C}");
        Console.WriteLine($"стоимость: {CalculateTotalCost():C}");
    }
}
class Program
{
    static void Main()
    {

        Order order = new Order("Негр в пене", 121221, 23);

        order.DisplayOrderInfo();
    }
}
