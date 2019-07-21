using System;
using a0_SimpleFactory.Fan.Interfaces;

namespace a0_SimpleFactory.Fan.Models
{
    internal class TableFan : IFan
    {
        public TableFan()
        {
            Console.WriteLine("Table fan has been made");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Table fan switched on");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Table fan switched off");
        }
    }
}
