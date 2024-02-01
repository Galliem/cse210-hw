

using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();

        var entry = new Entry();
        entry.prompt = "prompt1";
        entry.date = DateTime.Now.ToShortDateString();
        entry.content = "This is the content1";
        journal.AddEntry(entry);

        entry = new Entry();
        entry.prompt = "prompt2";
        entry.date = DateTime.Now.ToShortTimeString();
        entry.content = "This is the content2";
        journal.AddEntry(entry);

        var journalText = Export(journal);

        Console.Clear();
        System.Console.WriteLine("Journal Entries: ");
        System.Console.WriteLine(journalText);

        while(choice != 5){
            choice = int.Parse(Console.ReadLine());
            if (choice == 1){
                choice.AddEntry();
            }
            else if (choice == 2){
                Console.Clear();
                choice.DisplayChoice();
            }
            else
                System.Console.WriteLine();
        }
    }

    static int ShowMenu(){
        Console.WriteLine("Please select one of the following: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        int choice = Console.Read();

        return choice;
    }

    static string[] ReadFile(){
        Console.Write("Enter Filename: ");
        var filename = Console.ReadLine();
        return File.ReadAllLines(filename);
    }

    static void WriteFile(string[] lines){
        console
    }
    string GetPrompt(){
        
    }
    void Run()
    {

    }
    void SaveFile(){

    }

}