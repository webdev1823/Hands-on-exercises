using System;

class Program
{
    static void Main(string[] args)
    {
        double initialAmount = 10000;     // ₹10,000
        double growthRate = 0.08;         // 8% annual growth
        int forecastYears = 5;

        double result = FinancialForecast.CalculateFutureValue(initialAmount, growthRate, forecastYears);
        Console.WriteLine($"Predicted value after {forecastYears} years: ₹{result:F2}");
    }
}