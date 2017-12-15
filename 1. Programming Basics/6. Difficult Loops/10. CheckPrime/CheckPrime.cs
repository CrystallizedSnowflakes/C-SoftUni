using System;


namespace _10.CheckPrime
{
    class CheckPrime
    {
        static void Main()
        {
            //return - get out of the current method if it's Main
            //"void" - this methode doesn't return value
            //break - get out of the current loop
            //continue - ignore everything below the continue in hid block and go back to the next literation /i++
            
            // prime num - devided to 1 and itself only

            int num = int.Parse(Console.ReadLine());

            if (num < 2)
            {
                Console.WriteLine("Not prime");
                return;
            }
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % 1 == 0) //without remainder
                {
                    isPrime = false;
                    break;
                }
            }
            /*if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }*/
            Console.WriteLine(isPrime ? "Prime" : "Not prime");
        }
    }
}
