public class Listing:Activity{
    public Listing():base("Listing Activity", "This activity will help you relfect on the good things in your life by having you list as many things as you can in a certain area."){
    }
    private List<string> questions = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    
        Random random = new Random();
        public void selectRandomQuestions(){
        int question = random.Next(questions.Count);
        Console.WriteLine(question);
    }
    public void listingActivity(){
        int promptDuration1 = promptDuration();
        while(promptDuration1 != 0){
            System.Console.WriteLine(getName(), getDescription());
            Console.ReadLine();
        }
    }
}