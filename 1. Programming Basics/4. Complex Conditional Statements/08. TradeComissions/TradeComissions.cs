using System;


namespace _08.TradeComissions
{
    class TradeComissions
    {
        static void Main()
        {
            string city = Console.ReadLine().ToLower();
            double money = double.Parse(Console.ReadLine());
            double result = 0.0;

            switch (city)
            {
                case "sofia":
                    if (money >= 0 && money <= 500)
                    {
                        result = money * 0.05;
                    }
                    else if (money > 500 && money <= 1000)
                    {
                        result = money * 0.07;
                    }
                    else if (money > 1000 && money <= 10000)
                    {
                        result = money * 0.08;
                    }
                    else if(money > 10000)
                    {
                        result = money * 0.12;
                    }
                    break;
                case "plovdiv": 
                    if (money >= 0 && money <= 500)
                    {
                        result = money * 0.055;
                    }
                    else if (money > 500 && money <= 1000)
                    {
                        result = money * 0.08;
                    }
                    else if (money > 1000 && money <= 10000)
                    {
                        result = money * 0.12;
                    }
                    else if (money > 10000)
                    {
                        result = money * 0.145;
                    }
                    break;
                case "varna": 
                    if (money >= 0 && money <= 500)
                    {
                        result = money * 0.045;
                    }
                    else if (money > 500 && money <= 1000)
                    {
                        result = money * 0.075;
                    }
                    else if (money > 1000 && money <= 10000)
                    {
                        result = money * 0.1;
                    }
                    else if (money > 10000)
                    {
                        result = money * 0.13;
                    }
                    break;
            }
            if (result != 0)
            {
                Console.WriteLine("{0:f2}", result); //$"(result:f2)"
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
