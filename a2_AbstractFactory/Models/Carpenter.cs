using System;
using a2_AbstractFactory.Interfaces;

namespace a2_AbstractFactory.Models
{
    class Carpenter : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit wooden doors");
        }
    }
}
