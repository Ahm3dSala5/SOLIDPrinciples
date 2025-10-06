namespace OpenClosedPrinciple.After
{
    public static class QuestionBank
    {
        public static List<Question> GenerateQuestion()
        {
            return new List<Question>
        {
            // ========== WH QUESTIONS ==========
            new WritenQuestion
            {
                Title = "What is object-oriented programming (OOP)?",
                Mark = 5,
            },
            new WritenQuestion
            {
                Title = "Why do we use inheritance in C#?",
                Mark = 5,
            },
            new WritenQuestion
            {
                Title = "What is the difference between an interface and an abstract class?",
                Mark = 5,
            },
            new WritenQuestion
            {
                Title = "When should you use a struct instead of a class in C#?",
                Mark = 5,
            },
            new WritenQuestion
            {
                Title = "How does garbage collection work in .NET?",
                Mark = 5,
            },

            // ========== TRUE / FALSE QUESTIONS ==========
            new TrueOrFalaseQuestion
            {
                Title = "C# supports multiple inheritance directly through classes.",
                Mark = 7,
                Choices = new List<string> { "True", "False" }
            },
            new TrueOrFalaseQuestion
            {
                Title = "An interface can contain both abstract methods and method implementations.",
                Mark = 7,
                Choices = new List<string> { "True", "False" }
            },
            new TrueOrFalaseQuestion
            {
                Title = "Value types are stored in the stack memory by default.",
                Mark = 7,
                Choices = new List<string> { "True", "False" }
            },
            new TrueOrFalaseQuestion
            {
                Title = "The keyword 'var' in C# means dynamic typing.",
                Mark = 7,
                Choices = new List<string> { "True", "False" }
            },
            new TrueOrFalaseQuestion
            {
                Title = "All .NET applications must have at least one Main() method.",
                Mark = 7,
                Choices = new List<string> { "True", "False" }
            },

            // ========== MULTIPLE CHOICE QUESTIONS ==========
            new MCQsQuestion
            {
                Title = "Which of the following is NOT a C# access modifier?",
                Mark = 10,
                Choices = new List<string> { "A) public", "B) private", "C) protected", "D) include" }
            },
            new MCQsQuestion
            {
                Title = "Which keyword is used to handle exceptions in C#?",
                Mark = 10,
                Choices = new List<string> { "A) throw", "B) try", "C) catch", "D) finally" }
            },
            new MCQsQuestion
            {
                Title = "Which of the following collections guarantees unique elements?",
                Mark = 10,
                Choices = new List<string> { "A) List", "B) Dictionary", "C) HashSet", "D) Queue" }
            },
            new MCQsQuestion
            {
                Title = "Which LINQ method is used to filter a sequence?",
                Mark = 10,
                Choices = new List<string> { "A) Select", "B) Where", "C) OrderBy", "D) GroupBy" }
            },
            new MCQsQuestion
            {
                Title = "Which keyword is used to define a constant value in C#?",
                Mark = 10,
                Choices = new List<string> { "A) const", "B) static", "C) readonly", "D) final" }
            },

            new MatchQuestion()
            {
                Title = "Match Column A With Correct Value From Column B",
                Mark = 15,
                Pairs = new Dictionary<string, string>()
                {
                    { "A","b" },
                    { "B","a" },
                    { "C","c" },
                    { "D","e" },
                    { "E","d" },
                }
            },
             new MatchQuestion()
            {
                Title = "Match Column A With Correct Value From Column B",
                Mark = 15,
                Pairs = new Dictionary<string, string>()
                {
                    { "A","b" },
                    { "B","a" },
                    { "C","c" },
                    { "D","e" },
                    { "E","d" },
                }
            },
              new MatchQuestion()
            {
                Title = "Match Column A With Correct Value From Column B",
                Mark = 15,
                Pairs = new Dictionary<string, string>()
                {
                    { "A","b" },
                    { "B","a" },
                    { "C","c" },
                    { "D","e" },
                    { "E","d" },
                }
            },
               new MatchQuestion()
            {
                Title = "Match Column A With Correct Value From Column B",
                Mark = 15,
                Pairs = new Dictionary<string, string>()
                {
                    { "A","b" },
                    { "B","a" },
                    { "C","c" },
                    { "D","e" },
                    { "E","d" },
                }
            }


        };
        }
    }
}
