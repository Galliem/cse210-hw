namespace GoalProject;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.IO.Enumeration;
using System.Collections.Concurrent;

public class Goal{
    
    protected string name;
    public string getName(){
        return name;
    }
    protected string description;
    public string getDescription(){
        return description;
    }
    protected string points;
    public int getPoints(){
        int numberPoints = int.Parse(points);
        return numberPoints;
    }
    public int totalPoints;
    protected string setGoal;
    public readonly string DELIMITER = "~";

    protected string cAmount = Console.ReadLine();
    //int completeAmount = int.Parse(cAmount);

    public static List<string> goalList;
    // public static int totalAllPoints(){
    //     totalPoints.append(numberPoints);
    // }
    public static List<string> goalNumberedList;

    public virtual string goalDetails(){
        System.Console.WriteLine("What is the name of this goal?");
        string name = Console.ReadLine();
        System.Console.WriteLine("Describe the goal");
        string description = Console.ReadLine();
        System.Console.WriteLine("How many points is this goal worth?");
        string points = Console.ReadLine();
        string setGoal = name + DELIMITER + description + DELIMITER+ points;
        goalList.Append(setGoal);
        return setGoal;
    }
    public void goalMenu(){
        System.Console.WriteLine($"You have {totalPoints} points.");
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.WriteLine("Which type of goal would you like to create?");

        string s = Console.ReadLine();
        int selection = int.Parse(s);

        if (selection == 1){
            System.Console.WriteLine("You chose 1. Simple");
            System.Console.WriteLine("Press Enter");
            Simple simpleAction = new Simple();
            simpleAction.SimpleGoal();
            simpleAction.goalDetails();
            System.Console.WriteLine($" You created the following goal: {setGoal}");
        }
        else if (selection == 2){
            System.Console.WriteLine("You chose 2. Eternal");
            System.Console.WriteLine("Press Enter");
            Eternal eternalAction = new Eternal();
            //eternalAction.EternalGoal();
            eternalAction.goalDetails();
        }
        else if (selection == 3){
            System.Console.WriteLine("You chose 3. Checklist");
            System.Console.WriteLine("Press Enter");
            Checklist checklistAction = new Checklist();
            checklistAction.ChecklistGoal();
        }
        else{
            selection = 4;
        }
    }
    public void getEvent(){
        System.Console.WriteLine("The goals are: ");
        System.Console.WriteLine($"{goalNumberedList}");
        System.Console.WriteLine("Which goal did you accomplish?");
        string a = Console.ReadLine();
        int accomplishedGoal = int.Parse(a);
    }
}