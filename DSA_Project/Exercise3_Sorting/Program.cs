using System;


class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Customer Order Sorting System\n");



        Order[] orders =
        {

            new Order(101,"Rahul",5000),

            new Order(102,"Amit",9000),

            new Order(103,"John",2000),

            new Order(104,"Sam",7000)

        };



        Console.WriteLine("Original Orders:");

        DisplayOrders(orders);




        // Bubble Sort

        Console.WriteLine("\nAfter Bubble Sort:");

        Sorting.BubbleSort(orders);

        DisplayOrders(orders);





        // Reset array for Quick Sort

        Order[] orders2 =
        {

            new Order(101,"Rahul",5000),

            new Order(102,"Amit",9000),

            new Order(103,"John",2000),

            new Order(104,"Sam",7000)

        };



        Console.WriteLine("\nAfter Quick Sort:");

        Sorting.QuickSort(
            orders2,
            0,
            orders2.Length-1
        );


        DisplayOrders(orders2);


    }



    static void DisplayOrders(Order[] orders)
    {

        foreach(Order order in orders)
        {
            order.Display();
        }

    }

}