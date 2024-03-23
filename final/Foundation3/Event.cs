using System.Reflection;

namespace foundation3;
class Event{
    string eventType;
    string title;
    string date;
    string time;
    string address;
    string eventInfo;
    public void getEvent(){
        string description = eventType + title + date;
        string details = description + time + address;
        string fullDetails = details + eventType + eventInfo;
    }
    
}