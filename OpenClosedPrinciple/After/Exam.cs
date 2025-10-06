using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.After
{
    public class Exam
    {
        private List<OpenClosedPrinciple.After.Question> Questions { get; }
        public Exam(List<OpenClosedPrinciple.After.Question> questions)
        {
            this.Questions = questions;
        }

        public void PrintExam()
        {
            Console.WriteLine("========== C# EXAM ==========\n");
            int number = 1;
            foreach (var question in Questions)
            {
                Console.WriteLine($"Q{number++}. [{question.Mark} Marks]");
                question.Print();
                Console.WriteLine(new string('-', 50)); // separator
            }
            Console.WriteLine("\n========== END OF EXAM ==========");
        }

    }
}
