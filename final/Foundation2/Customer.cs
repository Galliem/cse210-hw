namespace foundation2;
class Customer{
    public void getCustomer(){
        System.Console.WriteLine("Enter your full name:");
        string name = Console.ReadLine();
        Address addressAction = new Address();
        addressAction.getAddress();
    }
    
}