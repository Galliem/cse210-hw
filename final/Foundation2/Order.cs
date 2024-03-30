namespace foundation2;
public class Order{
    // list of products and a customer
    private string customer;
    // calculate the total cost of the order
    //return string for shipping label
    public void getOrder(){
        Customer customerAction = new Customer();
        customerAction.getCustomer();
        Product productAction = new Product();
        productAction.getProduct();
        float totalProductCost = totalCost;
        float totalPrice =  totalProductCost + shippingCost;
        System.Console.WriteLine($"{totalPrice}");
        string shipLabel = name + address;
        string packLabel = $"{productName} + {id}";
        Console.WriteLine($"{shipping label}");
    }
}