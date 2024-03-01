public class Activity{

    string name;
    string description;
    int duration;
    int timeLeft;
    int currentTime;
    int futureTime;

    public Activity(string name, string description){
        this.name = name;
        this.description = description;
    }

void displayStartMessage(){
            Console.WriteLine("");
        }
    int promptDuration(){
        int duration = Console.Read("How long (in seconds) do you want to do this activity? ");
    }
    bool checkTime(){
        currentTime = DateTime.Now();
    };
    string getStartMessageInfo();
    string getEndMessageInfo();
    string selectRandomPrompt();
    string displayRandomQuestion();
};