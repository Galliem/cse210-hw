namespace foundation2;

// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

class Customer{
    public void getCustomer(){
        Address addressAction = new Address("Allie Garner", "1106 w 2102 S", "Rexburg", "ID", "United States");
        string address = addressAction.getAddress();
    }
    
}