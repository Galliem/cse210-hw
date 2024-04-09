namespace foundation3;
class Address:Event{
    string fullAddress;
    private string name;
    private string street;
    private string city;
    private string state;
    private string homeCountry;
    public Address(string name, string street, string city, string state, string homeCountry){
        this.name = name;
        this.street = street;
        this.city = city;
        this.state = state;
        this.homeCountry = homeCountry;
    }

    public string getAddress(){
        fullAddress = $"{street}\n{city}, {state}\n{homeCountry}";
        string shippingLabel = $"{name}\n{fullAddress}";
        return shippingLabel;
    }
}