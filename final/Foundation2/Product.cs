using System.Security.Cryptography.X509Certificates;

namespace foundation2;
public class Product{
    private float totalCost;
    private string productName;
    private int productId;
    private float price;
    private int quantity;

    public Product(string productName, int productId, float price, int quantity){
        this.productName = productName;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }
    //public float getProduct(){}
}