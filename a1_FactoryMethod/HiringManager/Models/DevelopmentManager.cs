using a1_FactoryMethod.HiringManager.Interfaces;

namespace a1_FactoryMethod.HiringManager.Models
{
    class DevelopmentManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new Developer();
        }
    }
}
