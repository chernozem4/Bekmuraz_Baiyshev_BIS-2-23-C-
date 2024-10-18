using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
public class Cars
{
    public string Car { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int PriceOfDay { get; set; }


    public Cars(string cars, string model, int year, int day)
    {
        
        Car = cars;
        Model = model;
        Year = year;
        PriceOfDay = day;
    }
    public decimal Calculatetotalcount(int day)
    {
       
        return PriceOfDay * day;
    }
    public void DisplayCarInfo()
    {
       
        Console.WriteLine($"Тачка: {Car}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Год выпуска: {Year}");
        Console.WriteLine($"цена аренды на дней {PriceOfDay}");
    }
}

class Bekmuraz
{
    
    static void Main(string[] args)
    {
        Cars cars = new Cars(
            "Totoya",
            "Cumry",
            1878,
            20

            );
        int ArendaNaDni = 20;
        decimal totalcount = cars.Calculatetotalcount(ArendaNaDni);
        Console.WriteLine($"Стоимость аренды равной {ArendaNaDni} дней расчитать полную сумму {totalcount} баксов  ");
        cars.DisplayCarInfo();

        
    }
}




