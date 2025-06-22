using System;

public class FinancialForecast
{
    // Recursive method to calculate future value
    public static double CalculateFutureValue(double currentValue, double rate, int years)
    {
        if (years == 0)
            return currentValue;

        return CalculateFutureValue(currentValue, rate, years - 1) * (1 + rate);
    }

    // Optional: Iterative version for optimization
    public static double CalculateFutureValueIterative(double currentValue, double rate, int years)
    {
        for (int i = 0; i < years; i++)
        {
            currentValue *= (1 + rate);
        }
        return currentValue;
    }
}