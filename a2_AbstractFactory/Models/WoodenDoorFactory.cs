using a2_AbstractFactory.Interfaces;

namespace a2_AbstractFactory.Models
{
    class WoodenDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new WoodenDoor();
        }

        public IDoorFittingExpert MakeDoorFittingExpert()
        {
            return new Carpenter();
        }
    }
}
