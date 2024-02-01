
public class Entry{
    public string DELIMETER = "|";
    public string date;
    public string prompt;
    public string response;

    public Entry(string date, string prompt, string response){
        this.response = response;
        this.prompt = prompt;
        this.date = date;
    }

    public Entry(string import){
        var parts = import.Split("|");
        this.date = parts[0];
        this.prompt = parts[1];
        this.response = parts[2];
    }
    
    public string Export(){
        return $"{date}|{prompt}|{response}";
    }
    public string DisplayString(){
        return $"{date} prompt: {prompt} response: {response}";
    }
}