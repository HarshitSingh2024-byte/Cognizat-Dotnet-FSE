using System;


class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Task Management System\n");


        TaskLinkedList taskList = new TaskLinkedList();




        Task t1 = new Task(
            1,
            "Complete Assignment",
            "Pending"
        );


        Task t2 = new Task(
            2,
            "Submit Project",
            "Completed"
        );


        Task t3 = new Task(
            3,
            "Prepare Presentation",
            "Pending"
        );




        // Add Tasks

        taskList.AddTask(t1);

        taskList.AddTask(t2);

        taskList.AddTask(t3);





        // Display Tasks

        taskList.DisplayTasks();





        // Search Task

        Console.WriteLine("\nSearching Task:");

        taskList.SearchTask(2);






        // Delete Task

        Console.WriteLine("\nDeleting Task:");

        taskList.DeleteTask(1);





        // Display After Delete

        taskList.DisplayTasks();

    }

}