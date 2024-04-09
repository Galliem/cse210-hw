namespace foundation4;
class Activity{
    string date;
    int activityLength;
    int distance;
    int speed;
    int pace;
    string summary;
    void getActivity(){
        // int distance;
        // int speed;
        // int pace;
        // string summary;
    }
    virtual void method(){
        distance=0;
        speed=0;
        pace=0;
    }
    void getSummary(){
        string summary;
    }
}