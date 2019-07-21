using System;
using a1_FactoryMethod.HiringManager.Interfaces;

namespace a1_FactoryMethod.HiringManager.Models
{
    class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about Design Patterns");
        }
    }
}
