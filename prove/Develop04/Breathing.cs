public class Breathing:Activity{

    public Breathing(): base ("Breathing", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing."){

    }

    public void BreathingActivity(){
        System.Console.WriteLine(getName(), getDescription());
        int promptDuration1 = promptDuration();
        while (promptDuration1 != 0){
            System.Console.WriteLine("Breathe in...");
            System.Console.Write("+");
            Thread.Sleep(4000); // 4 seconds
            System.Console.WriteLine("\b \b");
            System.Console.WriteLine("Breathe out...");
            Thread.Sleep(5000);
        } 
    }
}