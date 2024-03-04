using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("You have 0 points");
        System.Console.WriteLine("Menu Options:");
        System.Console.WriteLine("1. Create New Goal");
        System.Console.WriteLine("2. List Goals");
        System.Console.WriteLine("3. Save Goals");
        System.Console.WriteLine("4. Load Goals");
        System.Console.WriteLine("5. Record Event");
        System.Console.WriteLine("6. Quit");
        System.Console.WriteLine("Select a choice from the menu: ");
        string selection = Console.ReadLine();
    }
}