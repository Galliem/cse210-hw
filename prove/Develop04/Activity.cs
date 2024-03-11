using System.Reflection.Metadata.Ecma335;

public class Activity{

    private string name;
    private string description;
    public string getName(){
        return name;
    }
    public string getDescription(){
        return description;
    }
    public int duration;
    public DateTime startTime;
    Random random = new Random();

    public Activity(string name, string description){
        this.name = name;
        this.description = description;
    }

public int promptDuration(){
    Console.WriteLine("How long (in seconds) do you want to do this activity? ");
    string time = Console.ReadLine();
    int futureTime = int.Parse(time);
    return futureTime;
    }
};