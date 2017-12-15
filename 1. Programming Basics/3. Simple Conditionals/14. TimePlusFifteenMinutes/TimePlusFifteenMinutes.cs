using System;


namespace _14.TimePlusFifteenMinutes
{
    class TimePlusFifteenMinutes
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int inFifteen = minutes + 15;

            if (inFifteen < 60 && hour < 24)
            {
                hour += 0;
                minutes = inFifteen;
            }
            else if (inFifteen > 59 && hour < 24)
            {
                hour += 1;
                if (hour == 24)
                {
                    hour = 0;
                }
                inFifteen -= 60;
            }
            else
            {
                hour -= 24;
            }
            Console.WriteLine("{0}:{1:00}", hour, inFifteen);
        }
    }
}
