namespace a2_AbstractFactory.Interfaces
{
    interface IDoorFactory
    {
        IDoor MakeDoor();
        IDoorFittingExpert MakeDoorFittingExpert();
    }
}
