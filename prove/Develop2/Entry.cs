namespace Journal;

public class Entry {
    public readonly string DELIMETER = "~";

    public string prompt;
    public string content;
    public string date;

    public string Export() {
        return $"{date} {DELIMETER} {prompt} {DELIMETER} {content}";
    }
}