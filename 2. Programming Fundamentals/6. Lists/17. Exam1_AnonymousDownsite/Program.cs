using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _17.Exam1_AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfAffectedWebsites = int.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());
            
            decimal totalLoss = 0;
            for (int i = 0; i < countOfAffectedWebsites; i++)
            {
                string[] websiteData = Console.ReadLine().Split();
                string websiteName = string.Empty;
                decimal siteLoss = 0;
                foreach (var data in websiteData)
                {
                    websiteName = websiteData[0];
                    long siteVisits = long.Parse(websiteData[1]);
                    decimal siteCommercialPricePerVisit = decimal.Parse(websiteData[2]);

                    siteLoss = siteVisits * siteCommercialPricePerVisit;
                }
                totalLoss += siteLoss;
                Console.WriteLine(websiteName);
            }
            BigInteger securityToken = BigInteger.Pow(securityKey, countOfAffectedWebsites);

            Console.WriteLine("Total Loss: {0:F20}", totalLoss);
            Console.WriteLine("Security Token: {0}", securityToken);
        }
    }
}
