using a0_SimpleFactory.Fan.Models;

namespace a0_SimpleFactory.Fan.Interfaces
{
    interface IFanFactory
    {
        IFan CreateFan(FanType fanType);
    }
}
