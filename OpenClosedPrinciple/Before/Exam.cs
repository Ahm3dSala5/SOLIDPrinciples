using System.Runtime.Intrinsics.X86;

namespace OpenClosedPrinciple.Before
{
    public class Exam
    {
        private  List<Question> Questions { get; }
        public Exam(List<Question> questions)
        {
            this.Questions = questions;
        }

        // if i add other quesition i must change this method 
        // this vaiolate open closed principle
        public  void PrintExam()
        {
            Console.WriteLine("========== C# EXAM ==========\n");

            int number = 1;
            foreach (var question in Questions)
            {
                Console.WriteLine($"Q{number++}. ({question.QuestionType}) [{question.Mark} Marks]");
                Console.WriteLine(question.Title);

                // Print choices if available
                if (question.QuestionType == QuestionType.TrueOrFalse || 
                    question.QuestionType == QuestionType.MCQ)
                {
                    foreach (var choice in question.Choices)
                    {
                        Console.WriteLine("   " + choice);
                    }
                }
                else if (question.QuestionType == QuestionType.WH)
                {
                    Console.WriteLine("--------------[Your Answer Here]------------------");
                }

                Console.WriteLine(new string('-', 50)); // separator
            }

            Console.WriteLine("\n========== END OF EXAM ==========");
        }
    }
}
