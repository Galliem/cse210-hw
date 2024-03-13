namespace GoalProject;
using System;
using System.ComponentModel.Design;

public class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Menu Options:");
        System.Console.WriteLine("1. Create New Goal");
        System.Console.WriteLine("2. List Goals");
        System.Console.WriteLine("3. Save Goals");
        System.Console.WriteLine("4. Load Goals");
        System.Console.WriteLine("5. Record Event");
        System.Console.WriteLine("6. Quit");
        System.Console.WriteLine("Select a choice from the menu: ");
        string s = Console.ReadLine();
        int selection = int.Parse(s);

    

    if (selection == 1){
        System.Console.WriteLine("You selected: Create New Goal");
        Goal goalAction = new Goal();
        goalAction.goalMenu();
        System.Console.WriteLine("What is the name of this goal?");
        string name = Console.ReadLine();
        System.Console.WriteLine("Describe the goal");
        string description = Console.ReadLine();
        System.Console.WriteLine("How many points is this goal worth?");
        string points = Console.ReadLine();
    }

    else if (selection == 2){
        System.Console.WriteLine("You selected: List Goals");
        //System.Console.WriteLine(goalList);
    }
    else if (selection == 3){
        System.Console.WriteLine("You selected: Save Goals");
    }
    else if (selection == 4){
        System.Console.WriteLine("You selected: Load Goals");
    }
    else if (selection == 5){
        System.Console.WriteLine("You selected: Record Event");
    }
    else{
        selection = 6;
    }
}
}