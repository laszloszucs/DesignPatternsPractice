using System;
using a1_FactoryMethod.HiringManager.Models;

namespace a1_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var devManager = new DevelopmentManager();
            devManager.TakeInterview();

            var marketingManager = new MarketingManager();
            marketingManager.TakeInterview();

            Console.ReadKey();
        }
    }
}
