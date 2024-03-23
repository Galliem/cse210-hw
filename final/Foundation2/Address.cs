namespace foundation2;
class Address{
    public int shippingCost;
    string fullAddress;
    public int getAddress(){
        System.Console.WriteLine("Enter the address");
        System.Console.WriteLine("Street: ");
        string street = Console.ReadLine();
        System.Console.WriteLine("City: ");
        string city = Console.ReadLine();
        System.Console.WriteLine("State/Providence: ");
        string state = Console.ReadLine();
        System.Console.WriteLine("Country: ");
        string homeCountry = Console.ReadLine();
        if (homeCountry == "United States"){
            shippingCost = 5;
        }
        else{
            shippingCost = 35;
        }
        System.Console.WriteLine("\n The address you provided is:");
        fullAddress = $"{street}\n{city}, {state}\n{homeCountry}";
        System.Console.WriteLine($"{fullAddress}");
        return shippingCost;
    }
}