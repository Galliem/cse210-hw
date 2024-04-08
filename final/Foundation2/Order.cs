using System.Runtime.InteropServices;

namespace foundation2;

//Contains a list of products and a customer. 

public class Order{
    public void getOrder1(){
        Customer customerAction = new Customer();
        customerAction.getCustomer();
        Product product1 = new Product("shirt", 56123, 12, 1);
        product1.getPackLabel();
     //Can return a string for the packing label.
     //A packing label should list the name and product id of each product in the order.
        string packLabel1 = product1.getPackLabel();
        int cost1 = product1.getProductCost();
        System.Console.WriteLine($"{packLabel1}");

        Product product2 = new Product("shoes", 54789, 75, 2);
    //A packing label should list the name and product id of each product in the order.
    //Can return a string for the packing label.
        string packLabel2 = product2.getPackLabel();
        int cost2 = product2.getProductCost();
        System.Console.WriteLine($"{packLabel2}");

        Address addressAction = new Address("Allie Garner", "600 S 1st W", "Rexburg", "ID", "United States");
    //Can return a string for the shipping label.    
    //A shipping label should list the name and address of the customer
        string shippingLabel = addressAction.getAddress();
        System.Console.WriteLine($"\nShipping Label:\n\n{shippingLabel}\n");
    //If the customer lives in the USA, then the shipping cost is $5. Else shipping cost is $35.    
        int shippingCost = addressAction.getShippingCost();
        
    //Can calculate the total cost of the order.
    //The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
        float totalPrice1 =  cost1 + cost2 + shippingCost;
        System.Console.WriteLine($"Order total = ${totalPrice1}");
    }
    public void getOrder2(){
        Customer customerAction = new Customer();
        customerAction.getCustomer();
        Product product3 = new Product("scarf", 56787, 11, 4);
        product3.getPackLabel();
     //Can return a string for the packing label.
     //A packing label should list the name and product id of each product in the order.
        string packLabel3 = product3.getPackLabel();
        int cost3 = product3.getProductCost();
        System.Console.WriteLine($"{packLabel3}");

        Product product4 = new Product("gloves", 54789, 7, 5);
    //A packing label should list the name and product id of each product in the order.
    //Can return a string for the packing label.
        string packLabel4 = product4.getPackLabel();
        int cost4= product4.getProductCost();
        System.Console.WriteLine($"{packLabel4}");

        Address addressAction = new Address("Ben Scott", "345 Tenth Avenue SW", "Calgary", "Alberta", "Canada");
    //Can return a string for the shipping label.    
    //A shipping label should list the name and address of the customer
        string shippingLabel = addressAction.getAddress();
        System.Console.WriteLine($"\nShipping Label:\n\n{shippingLabel}\n");
    //If the customer lives in the USA, then the shipping cost is $5. Else shipping cost is $35.    
        int shippingCost = addressAction.getShippingCost();
        
    //Can calculate the total cost of the order.
    //The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
        float totalPrice1 =  cost3 + cost4 + shippingCost;
        System.Console.WriteLine($"Order total = ${totalPrice1}");
    } 
}