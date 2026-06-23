class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inventory Management System\n");

        Inventory inventory = new Inventory();

        Product p1 = new Product(
            101,
            "Laptop",
            10,
            55000
        );

        Product p2 = new Product(
            102,
            "Mobile",
            20,
            25000
        );

        inventory.AddProduct(p1);
        inventory.AddProduct(p2);

        inventory.DisplayProducts();

        inventory.UpdateProduct(101,15);

        inventory.DisplayProducts();

        inventory.DeleteProduct(102);

        inventory.DisplayProducts();
    }
}