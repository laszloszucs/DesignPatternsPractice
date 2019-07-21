using System;
using a2_AbstractFactory.Interfaces;

namespace a2_AbstractFactory.Models
{
    class WoodenDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I'm a wooden door");
        }
    }
}
