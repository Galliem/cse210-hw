public class Reflection:Activity{
    public Reflection(): base ("Relfection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life." ){
        }
    private List<string> prompts = ["Think of a time when you stood up for someone", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private List<string> questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to ther situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    Random random = new Random();
    public void selectRandomPrompt(){
        int prompt = random.Next(prompts.Count);
        Console.WriteLine(prompts[prompt]);
    }

    public void selectRandomQuestions(){
        int question = random.Next(questions.Count);
        Console.WriteLine(questions[question]);
    }
    public void reflectionActivity(){
        System.Console.WriteLine(getName(), getDescription());
        int promptDuration1 = promptDuration();
        while(promptDuration1 != 0){
            selectRandomPrompt();
            Thread.Sleep(4000);
            selectRandomQuestions();
            Thread.Sleep(4000);
            }
        }
}