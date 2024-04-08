using System.Security.Cryptography.X509Certificates;

namespace foundation2;

public class Product{
    private int totalCost;
    private string productName;
    private int productId;
    private int price;
    private int quantity;
    private int cost;

// Contains the name, product id, price per unit, and quantity of each product.
    public Product(string productName, int productId, int price, int quantity){
        this.productName = productName;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }
// The total cost of this product is computed by multiplying the price per unit and the quantity. 
    public int getProductCost(){
        int cost = totalCost + (price * quantity);
        return cost;
    }
    public string getPackLabel(){ 
        string packLabel = $"{productId} - {productName}";
        return packLabel;
    }
}