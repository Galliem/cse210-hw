namespace Journal;

class Program{
    static void Main(string[] args){
        var journal = new Journal();
        bool keepGoing = true;
    
static int ShowMenu(){
    System.Console.WriteLine("What would you like to do?");
    System.Console.WriteLine("1. Write");
    System.Console.WriteLine("2. Display");
    System.Console.WriteLine("3. Load");
    System.Console.WriteLine("4. Save");
    System.Console.WriteLine("5. Quit");
    var num = System.Console.ReadLine();
    int.TryParse(num, out int number);
    return number;
}
static string[] ReadFile(){
    Console.WriteLine("Enter filename: ");
    var filename = Console.ReadLine();
    return System.IO.File.ReadAllLines(filename);
}
static void WriteFile(string[] lines){
    Console.Write("Enter filename: ");
    var filename = Console.ReadLine();
    System.IO.File.WriteAllLines(filename, lines);
}

while(keepGoing){
Console.Clear();
int number = ShowMenu();

if (number == 1){//write
    var entry = new Entry();
    journal.AddEntry(entry);}

    else if (number ==2){ //Display
        var journalText = Export(journal);
        System.Console.WriteLine("Journal Entries: \n");
        System.Console.WriteLine(journalText);

        string Export(Journal journal){
            string finalExport = "";
            foreach (Entry entry in journal.entries){
            finalExport += $"{entry.date} {entry.DELIMETER} {entry.prompt} {entry.DELIMETER} {entry.content}" + "\n";
            }
        return finalExport;}
        }
    else if (number == 3){//Load or List
        Console.Clear();
        var lines = ReadFile();
        entry = new entry(lines);
    }
    else if (number == 4){//Save
        var lines = journal.Export();
        WriteFile(lines);
    }
    else{//Quit
        keepGoing = false;
    }

}}}