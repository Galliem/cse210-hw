public class Activity{

    string name;
    string description;
    int duration;
    int currentTime;
    int futureTime;

void displayStartMessage(){
            Console.WriteLine("");
        }
    int promptDuration();
    bool checkTime();
    string getStartMessageInfo();
    string getEndMessageInfo();
    string selectRandomPrompt();
    string displayRandomQuestion();
};