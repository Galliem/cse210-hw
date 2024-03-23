namespace foundation2;
class Order{
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