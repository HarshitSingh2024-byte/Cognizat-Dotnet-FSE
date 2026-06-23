class Forecast
{

    // Recursive method to calculate future value

    public double CalculateFutureValue(
        double currentValue,
        double growthRate,
        int years)
    {


        // Base condition
        if(years == 0)
        {
            return currentValue;
        }



        // Recursive call

        return CalculateFutureValue(
            currentValue * (1 + growthRate),
            growthRate,
            years - 1
        );

    }

}