namespace foundation3;
class Lecture{
    string description;
    string title;
    string date;
    string speakerName;
    int capacity;
    string eventInfo;
    public void getLecture(){
        eventInfo = speakerName + capacity;
    }
    public string Lecture(string description, string title, string date){
            this.description = description;
            this.title = title;
            this.date = date;
            return $"{title} - {date} - {description}"; 
    }
}