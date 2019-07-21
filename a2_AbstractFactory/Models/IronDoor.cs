using System;
using a2_AbstractFactory.Interfaces;

namespace a2_AbstractFactory.Models
{
    class IronDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I'm an iron door");
        }
    }
}
