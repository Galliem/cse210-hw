using System.Security.Cryptography.X509Certificates;

public class Goal{
    protected int points;
    public int getPoints(){
        return points;
    }
    protected string name;
    public string getName(){
        return name;
    }
    protected string description;
    public string getDescription(){
        return description;
    }

    public Goal(int points, string name, string description){
        this.points = points;
        this.name = name;
        this.description = description;
    }

    //recordEvent(){}
    //isComplete(){}
    void goalMenu(){
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.WriteLine("Which type of goal would you like to create?");

        string s = Console.ReadLine();
        int selection = int.Parse(s);

        if (selection == 1){
            //Goal simpleAction = new Goal();
            //simpleAction.SimpleGoal();
            System.Console.WriteLine("");
        }
        else if (selection == 2){
            //Goal eternalAction = new Goal();
            //eternalAction.EternalGoal();
            System.Console.WriteLine("");
        }
        else if (selection == 3){
            //Goal checklistAction = new Goal();
            //checklistAction.ChecklistGoal();
            System.Console.WriteLine("");
        }
        else{
            selection = 4;
        }
    }

}