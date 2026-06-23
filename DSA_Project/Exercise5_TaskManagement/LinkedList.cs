class TaskLinkedList
{

    private Task head;



    // Add Task

    public void AddTask(Task task)
    {

        if(head == null)
        {
            head = task;
        }
        else
        {

            Task current = head;


            while(current.Next != null)
            {
                current = current.Next;
            }


            current.Next = task;

        }


        Console.WriteLine("Task Added Successfully");

    }





    // Search Task

    public void SearchTask(int id)
    {

        Task current = head;


        while(current != null)
        {

            if(current.TaskId == id)
            {
                Console.WriteLine("Task Found:");

                current.Display();

                return;
            }


            current = current.Next;

        }


        Console.WriteLine("Task Not Found");

    }







    // Traverse Tasks

    public void DisplayTasks()
    {

        Console.WriteLine("\nTask List:");

        Task current = head;


        while(current != null)
        {

            current.Display();

            current = current.Next;

        }

    }






    // Delete Task

    public void DeleteTask(int id)
    {

        if(head == null)
        {
            Console.WriteLine("List Empty");
            return;
        }



        if(head.TaskId == id)
        {
            head = head.Next;

            Console.WriteLine("Task Deleted");

            return;
        }



        Task current = head;


        while(current.Next != null)
        {

            if(current.Next.TaskId == id)
            {

                current.Next = current.Next.Next;


                Console.WriteLine("Task Deleted");

                return;

            }


            current=current.Next;

        }


        Console.WriteLine("Task Not Found");

    }

}