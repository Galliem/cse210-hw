namespace GoalProject;
 public class Eternal:Goal{
    public Eternal():base(){}

    public void EternalGoal(){
      
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
      string setGoal = name + DELIMITER + description + DELIMITER+ points + completeAmount;
      goalList.Append(setGoal);
      return setGoal;
   } 
 }