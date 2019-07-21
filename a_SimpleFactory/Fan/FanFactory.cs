using System;
using a0_SimpleFactory.Fan.Interfaces;
using a0_SimpleFactory.Fan.Models;

namespace a0_SimpleFactory.Fan
{
    public class FanFactory : IFanFactory
    {
        public FanFactory()
        {
            Console.WriteLine("Fan Factory has been made");
        }

        public IFan CreateFan(FanType fanType)
        {
            switch (fanType)
            {
                case FanType.TableFan:
                    return new TableFan();
                case FanType.CeilingFan:
                    return new CeilingFan();
                case FanType.ExhaustFan:
                    return new ExhaustFan();
                default:
                    return null;
            }
        }
    }
}
