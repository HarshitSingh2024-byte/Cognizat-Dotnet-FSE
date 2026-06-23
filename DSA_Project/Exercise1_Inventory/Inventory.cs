using System.Collections.Generic;


class Inventory
{

    // HashMap equivalent in C#
    Dictionary<int, Product> products = new Dictionary<int, Product>();


    // Add Product
    public void AddProduct(Product product)
    {
        products.Add(product.ProductId, product);

        Console.WriteLine("Product Added Successfully");
    }



    // Update Product Quantity
    public void UpdateProduct(int id, int quantity)
    {

        if(products.ContainsKey(id))
        {
            products[id].Quantity = quantity;

            Console.WriteLine("Product Updated Successfully");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }

    }



    // Delete Product
    public void DeleteProduct(int id)
    {

        if(products.ContainsKey(id))
        {
            products.Remove(id);

            Console.WriteLine("Product Deleted Successfully");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }

    }



    // Display Inventory
    public void DisplayProducts()
    {

        Console.WriteLine("\nInventory List:");

        foreach(Product product in products.Values)
        {
            product.Display();
        }

    }

}