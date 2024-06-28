using OrderProduct;

public static class Program
{
    public static void Main(string[] args)
    {
        Electronic electronic1 = new Electronic ("Dyson", 500, "Aluminium");
        Electronic electronic2 = new Electronic("Dyson2", 550, "Steal");

        Clothes clothes1 = new Clothes("t shirt", "M", 20);
        Clothes clothes2 = new Clothes("Jeans", "L", 60);

        Order order = new Order();
        order.AddProduct(clothes1);
        order.AddProduct(clothes2);
        order.AddProduct(electronic2);  
        order.AddProduct(electronic1);
        order.RemoveProduct(clothes1);
        
        order.GetDetails();
        Console.WriteLine(order.GetTotalAmount());

    }
}