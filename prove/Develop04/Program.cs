using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

public class Program{
    static void Main(string[] args){

        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        int i = 0;
        string endMessage = "Good Job!";

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("/");
        animationStrings.Add("|");
        animationStrings.Add("-");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        while(DateTime.Now < endTime){
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        if (number == 1){

            Breathing.BreathingActivity();
            countdown();
            Console.WriteLine($"{endMessage}");
        }
        else if (number == 2)
        {
            Reflection();
            countdown();
            Console.WriteLine($"{endMessage}");
        }
        else if (number == 3)
        {
            Listing();
            countdown();
            Console.WriteLine($"{endMessage}");
        }
        else
        {
            number = 4;
        }
}
}