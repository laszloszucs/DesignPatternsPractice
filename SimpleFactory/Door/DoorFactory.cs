using System;

namespace SimpleFactory.Door
{
    class DoorFactory
    {
        public DoorFactory()
        {
            Console.WriteLine("Door Factory has been made");
        }
        public IDoor MakeDoor(double width, double height)
        {
            Console.WriteLine("Door Factory made a door");
            return new WoodenDoor(width, height);
        }
    }
}
