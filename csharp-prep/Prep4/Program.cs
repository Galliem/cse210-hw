using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        // Lists - new keyword
List<int> myInts = new List<int>();
var moreInt = new List<int>();

moreInt.Add(34);

//iterate over items
foreach(var n in moreInt) {
    System.Console.WriteLine($"n = {n}");  
}
    }
}