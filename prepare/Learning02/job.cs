namespace Learning02;
public class Job
{
    public string _jobTitle; 
    public string _jobCompany;
    public int _startYear;
    public int _endYear;

    public Job() {}
    public void Display()
    
    {
        System.Console.WriteLine($"{_jobTitle} {_jobCompany} {_startYear}-{_endYear}");
    }

}