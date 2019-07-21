using System;
using a1_FactoryMethod.HiringManager.Interfaces;

namespace a1_FactoryMethod.HiringManager.Models
{
    class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about community building");
        }
    }
}
