using System;


class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Library Management System\n");



        Book[] books =
        {

            new Book(101,"Algorithms","Cormen"),

            new Book(102,"Database","Korth"),

            new Book(103,"Java","James"),

            new Book(104,"Operating System","Galvin")

        };



        Library library = new Library();





        // Linear Search

        Console.WriteLine("Linear Search Result:");

        Book result1 =
            library.LinearSearch(books,"Java");



        if(result1 != null)
        {
            result1.Display();
        }
        else
        {
            Console.WriteLine("Book Not Found");
        }







        // Sort books before Binary Search

        Array.Sort(
            books,
            (a,b) => a.Title.CompareTo(b.Title)
        );



        Console.WriteLine("\nSorted Books:");

        foreach(Book book in books)
        {
            book.Display();
        }





        // Binary Search

        Console.WriteLine("\nBinary Search Result:");

        Book result2 =
            library.BinarySearch(
                books,
                "Algorithms"
            );



        if(result2 != null)
        {
            result2.Display();
        }
        else
        {
            Console.WriteLine("Book Not Found");
        }


    }

}