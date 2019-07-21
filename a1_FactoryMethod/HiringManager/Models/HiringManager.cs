using a1_FactoryMethod.HiringManager.Interfaces;

namespace a1_FactoryMethod.HiringManager.Models
{
    abstract class HiringManager
    {
        // Factory method
        protected abstract IInterviewer MakeInterviewer();

        public void TakeInterview()
        {
            IInterviewer interviewer = MakeInterviewer();
            interviewer.AskQuestions();
        }
    }
}
