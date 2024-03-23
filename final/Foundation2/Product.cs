using System.Security.Cryptography.X509Certificates;

namespace foundation2;
class Product{
    private float totalCost;
    public float getProduct(){
        System.Console.WriteLine("Enter product name:");
        string productName = Console.ReadLine();
        System.Console.WriteLine("Enter the product id number:");
        string productId = Console.ReadLine();
        int id = int.Parse(productId);
        System.Console.WriteLine($"Enter the price per unit:");
        string unitPrice = Console.ReadLine();
        float price = float.Parse(unitPrice);
        System.Console.WriteLine("Enter the quantity you want to order:");
        string unitQuantity = Console.ReadLine();
        int quantity = int.Parse(unitQuantity);
        float totalCost = price * quantity;
        return totalCost;
    }
}