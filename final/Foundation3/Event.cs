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
        // string description = eventType + title + date;
        // string details = description + date + time + address;
        // string fullDetails = details + eventType + eventInfo;
        Address addressAction = new Address("John Doe", "101 State Street", "Chicago Heights", "IL", "United States");
        string address = addressAction.getAddress();
        Lecture lectureAction = new Lecture("This lecture is for art students at BYU-Idaho", "Art Lecture","03/15/2023");
        string lecture = lectureAction.getLecture();
    }
}