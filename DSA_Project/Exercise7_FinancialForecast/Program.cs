using System;


class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Financial Forecasting System\n");



        Forecast forecast = new Forecast();




        double currentValue = 10000;

        double growthRate = 0.10;   // 10% growth

        int years = 5;





        double futureValue =
            forecast.CalculateFutureValue(
                currentValue,
                growthRate,
                years
            );




        Console.WriteLine(
            "Current Value: " + currentValue
        );


        Console.WriteLine(
            "Growth Rate: " + (growthRate * 100) + "%"
        );


        Console.WriteLine(
            "Years: " + years
        );


        Console.WriteLine(
            "Future Value: " + futureValue
        );


    }

}