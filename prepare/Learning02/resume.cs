using System;
namespace Learning02;
public class Resume{
    public List<Job> _jobs = new List<Job>();
    public string _name = "";

    public void Display()
    {
        
        System.Console.WriteLine($"Name: {_name}");
        System.Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }
}