using System;
namespace foundation2;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Foundation2 Encapsulation Ordering");
        Order orderAction = new Order();
        orderAction.getOrder();

        System.Console.WriteLine("Thank You!");
    }
}