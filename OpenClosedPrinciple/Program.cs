using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OpenClosedPrinciple
{
    // Definition
    //“Software entities(classes, modules, functions, etc.)
    //should be open for extension, but closed for modification.”

    // The Open/Closed Principle (OCP) is primarily achieved through abstraction —
    // and often supported by generalization and polymorphism.

    //Generalization means you take common logic from specific implementations
    //and move it to a more general structure (like a base class or interface).

    public class EntryPoint
    {
        static void Main()
        {
            BeforeApplyOpenClosedPrinciple();
            // =================================================================== //
            AfterApplyOpenClosedPrinciple();
        }

        static void BeforeApplyOpenClosedPrinciple()
        {
            var exam = new Before.Exam(Before.QuestionBank.GenerateQuestion());
            exam.PrintExam();
        }

        static void AfterApplyOpenClosedPrinciple()
        {
            var exam = new After.Exam(After.QuestionBank.GenerateQuestion());
            exam.PrintExam();
        }
    }
}