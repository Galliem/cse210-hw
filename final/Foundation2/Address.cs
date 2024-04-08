namespace foundation2;
class Address{
    public int shippingCost;
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
    
    public int getShippingCost(){
        if (homeCountry == "United States"){
            shippingCost = 5;
        }
        else{
            shippingCost = 35;
        }
        return shippingCost;
    }
    public string getAddress(){
        fullAddress = $"{street}\n{city}, {state}\n{homeCountry}";
        string shippingLabel = $"{name}\n{fullAddress}";
        return shippingLabel;
    }
}