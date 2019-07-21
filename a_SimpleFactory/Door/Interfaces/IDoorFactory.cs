namespace a0_SimpleFactory.Door.Interfaces
{
    internal interface IDoorFactory
    {
        IDoor MakeDoor(double width, double height);
    }
}
