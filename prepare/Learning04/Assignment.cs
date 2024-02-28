using System.Security.Cryptography;

public class Assignment{
    protected string _studentName;
    private string _topic;
    public string getSummary(){
        return ($"{_studentName} - {_topic}");
    }
    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;

    }
}