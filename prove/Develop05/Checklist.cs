namespace GoalProject;
 public class Checklist:Goal{
     public Checklist():base(){
        
     }

    public void ChecklistGoal(){

    }
    public override string goalDetails(){
    System.Console.WriteLine("What is the name of this goal?");
    string name = Console.ReadLine();
    System.Console.WriteLine("Describe the goal");
    string description = Console.ReadLine();
    System.Console.WriteLine("How many points is this goal worth?");
    string points = Console.ReadLine();
    System.Console.WriteLine("How many times does this goal need to be completed for a bonus?");
    string completeAmount = Console.ReadLine();
    System.Console.WriteLine($"What is the bonus for accomplishing it {completeAmount} of times?");
    string endBonus = Console.ReadLine();
    string setGoal = name + DELIMITER + description + DELIMITER+ points + completeAmount + endBonus;
    goalList.Append(setGoal);
    return setGoal;
   } 
 }