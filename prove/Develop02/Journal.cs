namespace Journal;
public class Journal {
    public List<Entry> entries;

    public Journal() {
        entries = new List<Entry>();
    }

    public Journal(string[] importLines){
        entries = new List<Entry>();
        foreach (var line in importLines){
            var entry = new Entry();
            entry.prompt = "What was the best part of my day?";
            entry.date = DateTime.Now.ToShortDateString();
            entry.content = System.Console.ReadLine();
            entries.Add(entry);
        }
    }

    public void AddEntry(Entry entry) {
        entries.Add(entry);
 
    }

    public string[] Export() {
        return [];
    }
}