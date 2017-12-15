using System;
using System.Globalization;


namespace _13.ThousandDaysAfterBirth
{
    class ThousandDaysAfterBirth
    {
        static void Main()
        {
            //string birthday = Console.ReadLine();
            //string format = "dd-MM-yyyy";
            //CultureInfo provider = CultureInfo.InvariantCulture;
            //
            //DateTime date = DateTime.ParseExact(birthday, format, provider);
            //
            //Console.WriteLine("{0}", date.AddDays(999).ToString(format));
           /* string date = Console.ReadLine();
            DateTime birthday = DateTime.ParseExact(date, "dd-MM-yyyy", null);

            //Console.WriteLine(birthday);
            DateTime result = birthday.AddDays(999);

            //Console.WriteLine(result.ToString("dd-MM-yyyy"));
            Console.WriteLine("{0:dd-MM-yyyy}", result);*/

            Console.WriteLine(DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null).AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
