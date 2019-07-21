using System;
using a0_SimpleFactory.Fan.Interfaces;

namespace a0_SimpleFactory.Fan.Models
{
    internal class ExhaustFan : IFan
    {
        public ExhaustFan()
        {
            Console.WriteLine("Exhaust fan has been made");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Exhaust fan switched on");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Exhaust fan switched off");
        }
    }
}
