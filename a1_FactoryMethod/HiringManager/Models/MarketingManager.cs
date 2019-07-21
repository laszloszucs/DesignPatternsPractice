using a1_FactoryMethod.HiringManager.Interfaces;

namespace a1_FactoryMethod.HiringManager.Models
{
    class MarketingManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
