using System;
using System.Buffers;
using Microsoft.VisualBasic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
    }

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entered Cars: ");
    
    var cars = new List<Car>();

        var Car2 = new Car();
        Car2.make = "Honda";
        Car2.model = "Civic";
        Car2.year = 2012;
        Car2.color = "Blue";
        Car2.gallons = 20;
        Car2.milesPerGallon = 25;

        var owner = new Owner();
        owner.name = "Scott";
        owner.phone = "568-2599";
        car.Owner = owner;

        cars.Add(Car2);

        var owner = new Owner();
            owner.name = "Allie";
            owner.phone = "226-4417";
            car.Owner = owner;

        var Car1 = new Car("Pontiac", "Grand Prix", 2007, "Silver", 16, 20, owner);

        cars.Add(Car1);

        foreach (var c in cars){
            c.Display();
            int range = c.TotalRange();
        }
}

public class Car{
    public string make;
    public string model;
    public int year;
    public string color;
    public int gallons;
    public int milesPerGallon;
    public Owner owner;

    public Car(string make, string model, int year, string color, int gallons, int milesPerGallon, Owner owner){
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
        this.gallons = gallons;
        this.milesPerGallon = milesPerGallon;
    }

public class Owner{
    public string name;
    public string phone;
}

    public int TotalRange(){
        return gallons * milesPerGallon;
    }
    public void Display(){
        System.Console.WriteLine($"{make} {model} {year} {color}: Range = {TotalRange()} miles");
    }
        }
}

}