using System;
namespace foundation2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation2 Encapsulation Ordering\n");
        Order orderAction = new Order();
        System.Console.WriteLine("First Order:\n");
        orderAction.getOrder1();
        System.Console.WriteLine("\nSecond Order:\n");
        orderAction.getOrder2();

        System.Console.WriteLine("Thank You!");
    }
}