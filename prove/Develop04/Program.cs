using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options");
        System.Console.WriteLine("1. Breathing Activity");
        System.Console.WriteLine("2. Reflection Activity");
        System.Console.WriteLine("3. Listing Activity");
        System.Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        int number = 1;
        string endMessage = "Good Job!";

        while (number != 5){
            if number == 1{
                breathing();
                Console.WriteLine($"{endMessage}");
            }
            else if number == 2{
                Reflection();
                Console.WriteLine($"{endMessage}");
            }
            else if number == 3{
                Listing();
                Console.WriteLine($"{endMessage}");
            }
            else{
                
            }
        }
    }
}