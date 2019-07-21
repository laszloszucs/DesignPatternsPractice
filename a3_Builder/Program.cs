using System;
using a3_Builder.Models;

namespace a3_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var burger = new BurgerBuilder(12)
                .AddPepperoni()
                .AddCheese()
                .AddLettuce()
                .AddTomato()
                .Build();

            burger.PrintDetails();

            Console.ReadKey();
        }
    }
}
