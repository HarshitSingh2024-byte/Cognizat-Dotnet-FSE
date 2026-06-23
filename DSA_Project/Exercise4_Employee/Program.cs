using System;


class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Employee Management System\n");



        EmployeeManagement management =
            new EmployeeManagement(10);




        Employee e1 =
            new Employee(
                101,
                "Rahul",
                "Developer",
                50000
            );



        Employee e2 =
            new Employee(
                102,
                "Amit",
                "Manager",
                70000
            );



        Employee e3 =
            new Employee(
                103,
                "John",
                "Tester",
                40000
            );





        // Add Employees

        management.AddEmployee(e1);

        management.AddEmployee(e2);

        management.AddEmployee(e3);




        // Traverse

        management.DisplayEmployees();




        // Search

        Console.WriteLine("\nSearching Employee:");

        management.SearchEmployee(102);




        // Delete

        Console.WriteLine("\nDeleting Employee:");

        management.DeleteEmployee(101);



        management.DisplayEmployees();

    }

}