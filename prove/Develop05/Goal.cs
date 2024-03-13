namespace GoalProject;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.IO.Enumeration;

public class Goal{
    
    protected string name;
    public string getName(){
        return name;
    }
    protected string description;
    public string getDescription(){
        return description;
    }
    protected int points;
    public int getPoints(){
        return points;
    }

    protected string cAmount = Console.ReadLine();
    //int completeAmount = int.Parse(cAmount);

    public List<string> goalList;

    // private string filename = "myFile.txt";
    // private string[] lines = System.IO.File.ReadAllLines(filename);
    // foreach (string line in lines){
    //     string[] parts = line.split(",");
    //     string goal = parts[0];
    //     string points = parts[1];
    // }

    // using(StreamWriter outputFile = new StreamWriter(FileSystemName))
    // {
    //     outputFile.WriteLine("First line in file.");
    //     string color = "Blue";
    //     outputFile.WriteLine($"My favorite color is {color}");
    // }

    //recordEvent(){}
    //isComplete(){}
    public void goalMenu(){
        System.Console.WriteLine($"You have {points} points.");
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.WriteLine("Which type of goal would you like to create?");

        string s = Console.ReadLine();
        int selection = int.Parse(s);

        if (selection == 1){
            Goal simpleAction = new Goal();
            //simpleAction.SimpleGoal();
            System.Console.WriteLine("");
        }
        else if (selection == 2){
            Goal eternalAction = new Goal();
            //eternalAction.EternalGoal();
            System.Console.WriteLine("");
        }
        else if (selection == 3){
            Goal checklistAction = new Goal();
            System.Console.WriteLine("How many times does this goal need to be completed for a bonus?");
            string completeAmount = Console.ReadLine();
            //checklistAction.ChecklistGoal();
            System.Console.WriteLine("");
        }
        else{
            selection = 4;
        }
    }

}