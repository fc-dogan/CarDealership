using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Info;

  public Car(string makeModel, int price, int miles, string info)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Info = info;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (Price < maxPrice);
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "This car is red, with a rustic feel.");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "This car is blue, making you feel like you are flying.");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "This car is green like driving in the forest.");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "This car is pink just like Barbie.");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
      Console.WriteLine(automobile.Info);
      Console.WriteLine("Miles: " + automobile.Miles); 
    }
  }
}