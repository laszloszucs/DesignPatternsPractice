using System;

namespace a3_Builder.Models
{
    class Burger
    {
        protected int Size;

        protected bool Cheese;
        protected bool Pepperoni;
        protected bool Lettuce;
        protected bool Tomato;

        public Burger(BurgerBuilder builder)
        {
            Size = builder.Size;
            Cheese = builder.Cheese;
            Pepperoni = builder.Pepperoni;
            Lettuce = builder.Lettuce;
            Tomato = builder.Tomato;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Cheese: {Cheese}");
            Console.WriteLine($"Pepperoni: {Pepperoni}");
            Console.WriteLine($"Lettuce: {Lettuce}");
            Console.WriteLine($"Tomato: {Tomato}");
        }
    }
}
