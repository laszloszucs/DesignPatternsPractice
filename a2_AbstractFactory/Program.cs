using System;
using a2_AbstractFactory.Interfaces;
using a2_AbstractFactory.Models;

namespace a2_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            WoodenDoorFactory woodenDoorFactory = new WoodenDoorFactory();
            IDoor door = woodenDoorFactory.MakeDoor();
            IDoorFittingExpert expert = woodenDoorFactory.MakeDoorFittingExpert();
            
            door.GetDescription();
            expert.GetDescription();

            IronDoorFactory ironDoorFactory = new IronDoorFactory();
            IDoor door2 = ironDoorFactory.MakeDoor();
            IDoorFittingExpert expert2 = ironDoorFactory.MakeDoorFittingExpert();
            
            door2.GetDescription();
            expert2.GetDescription();

            Console.ReadKey();
        }
    }
}
