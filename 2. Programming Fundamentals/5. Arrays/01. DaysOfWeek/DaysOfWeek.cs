using System;

class DaysOfWeek
{
    static void Main()
    {
        string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        int day = int.Parse(Console.ReadLine());

        if (day >= 1 && day <= 7)
        {
            Console.WriteLine(daysOfWeek[day - 1]); // day = 2 -> 2-1=1 -> 0 - Monday, 1 - Tuesday
        }
        else
        {
            Console.WriteLine("Invalid Day!");
        }
    }
}

