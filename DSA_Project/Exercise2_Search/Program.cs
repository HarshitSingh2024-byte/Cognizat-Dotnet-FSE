using System;


class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("E-Commerce Search System\n");



        Product[] products =
        {

            new Product(1,"Laptop","Electronics"),

            new Product(2,"Mobile","Electronics"),

            new Product(3,"Book","Education"),

            new Product(4,"Tablet","Electronics")

        };



        // Linear Search

        Console.WriteLine("Linear Search Result:");

        Product result1 =
            SearchAlgorithm.LinearSearch(products,"Mobile");


        if(result1 != null)
            result1.Display();

        else
            Console.WriteLine("Product Not Found");





        // Sort array for Binary Search

        Array.Sort(products,
        (a,b)=>
        a.ProductName.CompareTo(b.ProductName));



        Console.WriteLine("\nSorted Products:");

        foreach(Product p in products)
        {
            p.Display();
        }





        // Binary Search

        Console.WriteLine("\nBinary Search Result:");

        Product result2 =
            SearchAlgorithm.BinarySearch(products,"Book");



        if(result2 != null)
            result2.Display();

        else
            Console.WriteLine("Product Not Found");

    }

}