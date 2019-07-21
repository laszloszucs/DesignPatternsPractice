using System;
using a0_SimpleFactory.Door.Interfaces;
using a0_SimpleFactory.Door.Models;

namespace a0_SimpleFactory.Door
{
    public class DoorFactory: IDoorFactory
    {
        public DoorFactory()
        {
            Console.WriteLine("Door factory has been made");
        }

        public IDoor MakeDoor(double width, double height)
        {
            return new WoodenDoor(width, height);
        }
    }
}
