using a2_AbstractFactory.Interfaces;

namespace a2_AbstractFactory.Models
{
    class IronDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new IronDoor();
        }

        public IDoorFittingExpert MakeDoorFittingExpert()
        {
            return new Welder();
        }
    }
}
