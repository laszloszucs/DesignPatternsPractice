using System;
using a0_SimpleFactory.Door;

namespace a0_SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FanFactory

            //FanFactory fanFactory = new FanFactory();
            //var fan1 = fanFactory.CreateFan(FanType.TableFan);
            //fan1.SwitchOn();

            //var fan2 = fanFactory.CreateFan(FanType.CeilingFan);
            //fan2.SwitchOn();

            //var fan3 = fanFactory.CreateFan(FanType.ExhaustFan);
            //fan3.SwitchOn();

            //fan1.SwitchOff();
            //fan2.SwitchOff();
            //fan3.SwitchOff();

            #endregion

            #region DoorFactory

            DoorFactory doorFactory = new DoorFactory();
            var door1 = doorFactory.MakeDoor(500, 1300);
            door1.PrintDimensions();

            #endregion

            Console.ReadKey();
        }
    }
}
