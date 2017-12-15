using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numOfPrice = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numOfPrice - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = PercentageCalculation(lastPrice, currentPrice);
            bool isSignificantDifference = HasDifference(difference, significanceThreshold);
            string message = GetUpdatedPriceMessage(currentPrice, lastPrice, difference, isSignificantDifference);
            lastPrice = currentPrice;
            Console.WriteLine(message);
        }
    }

    static string GetUpdatedPriceMessage(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        return message;
    }

    static bool HasDifference(double significanceThreshold, double difference)
    {
        if (Math.Abs(significanceThreshold) >= difference)
        {
            return true;
        }
        return false;
    }

    static double PercentageCalculation(double lastPrice, double currentPrice)
    {
        double percent = (currentPrice - lastPrice) / lastPrice;
        return percent;
    }       
}


