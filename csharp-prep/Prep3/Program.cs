using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int count = 5;

        while (count < 10) {
            Console.WriteLine($"Count = {count}");
            count += 1;
        }

        int anotherCount = 0;
        do {
            System.Console.WriteLine($"AnotherCount = {anotherCount++}");
        } while (anotherCount < 10);

        for (int i=0; i<5; ++i) {
            System.Console.WriteLine($"i = {i}");
        }
        
    }
}