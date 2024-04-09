namespace foundation3;
class Reception{
    string description;
    string title;
    string date;
    string emailRSVP;
    string eventInfo;
    void getReception(){
        eventInfo = "";
        emailRSVP = "johndoe@gmail.com";
    }
     public Reception(string description, string title, string date){
            this.description = description;
            this.title = title;
            this.date = date;
     }
}