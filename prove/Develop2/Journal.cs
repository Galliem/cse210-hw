namespace Journal;
public class Journal {
    public List<Entry> entries;

    public Journal(string[] importLines){
        entries = new List<Entry>();
        foreach (var line in importLines){
            var entry = new Entry();
            entry.prompt = "What was the best part of my day?";
            entry.date = DateTime.Now.ToShortDateString();
            entry.content = System.Console.ReadLine();
            entry.Add(entries);
        }
    }

    public void AddEntry(Entry entry) {
        entries.Add(entry);
 
    }
}