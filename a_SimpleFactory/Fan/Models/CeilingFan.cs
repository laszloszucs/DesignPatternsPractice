using System;
using a0_SimpleFactory.Fan.Interfaces;

namespace a0_SimpleFactory.Fan.Models
{
    internal class CeilingFan : IFan
    {
        public CeilingFan()
        {
            Console.WriteLine("Ceiling fan has been made");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Ceiling fan switched on");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Ceiling fan switched off");
        }
    }
}
