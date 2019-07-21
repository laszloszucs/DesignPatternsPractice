using System;
using SimpleFactory.Door;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var doorFactory = new DoorFactory();
            var door = doorFactory.MakeDoor(100,100);
            door.PrintDoorParams();
            var door2 = doorFactory.MakeDoor(200, 200);
            door2.PrintDoorParams();

            Console.Write("\nPress a key to Exit...");
            Console.ReadKey();
        }
    }
}
