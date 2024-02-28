public class Breathing:Activity{

    Breathing(): base ("Breathing", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing."){

    }

    string breathingActivity(){
        while timeLeft != 0{
            System.Console.WriteLine("Breathe in...");
            System.Console.Write("+");
            Thread.Sleep(1000);
            System.Console.WriteLine("\b \b");
            Console.Write("-");
            System.Console.WriteLine("Breathe out...");
        }
        
    }
}