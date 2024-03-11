using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

public class Program{
    static void Main(string[] args){

        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string i = Console.ReadLine();
        int selection = int.Parse(i);
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
            string s = animationStrings[selection];
            Console.Write(s);
            Thread.Sleep(3000);
            Console.Write("\b \b");
        }

        if (selection == 1){

            Breathing breathingAction = new Breathing();
            //countdown();
            breathingAction.BreathingActivity();
            Console.WriteLine($"{endMessage}");
            
        }
        else if (selection == 2)
        {
            Reflection reflectionAction = new Reflection();
            reflectionAction.reflectionActivity();
            //countdown();
            Console.WriteLine($"{endMessage}");
        }
        else if (selection == 3)
        {
            Listing listingAction = new Listing();
            //countdown();
            Console.WriteLine($"{endMessage}");
        }
        else
        {
            selection = 4;
        }
        }}