namespace OpenClosedPrinciple.Before
{
    public static class QuestionBank
    {
        public static List<Question> GenerateQuestion()
        {
            return new List<Question>
        {
            // ========== WH QUESTIONS ==========
            new Question
            {
                Title = "What is object-oriented programming (OOP)?",
                QuestionType = QuestionType.WH,
                Mark = 5,
            },
            new Question
            {
                Title = "Why do we use inheritance in C#?",
                QuestionType = QuestionType.WH,
                Mark = 5,
            },
            new Question
            {
                Title = "What is the difference between an interface and an abstract class?",
                QuestionType = QuestionType.WH,
                Mark = 5,
            },
            new Question
            {
                Title = "When should you use a struct instead of a class in C#?",
                QuestionType = QuestionType.WH,
                Mark = 5,
            },
            new Question
            {
                Title = "How does garbage collection work in .NET?",
                QuestionType = QuestionType.WH,
                Mark = 5,
            },

            // ========== TRUE / FALSE QUESTIONS ==========
            new Question
            {
                Title = "C# supports multiple inheritance directly through classes.",
                QuestionType = QuestionType.TrueOrFalse,
                Mark = 7,
                Choices = new List<string> { "True", "False" }
            },
            new Question
            {
                Title = "An interface can contain both abstract methods and method implementations.",
                QuestionType = QuestionType.TrueOrFalse,
                Mark = 7,
                Choices = new List<string> { "True", "False" }
            },
            new Question
            {
                Title = "Value types are stored in the stack memory by default.",
                QuestionType = QuestionType.TrueOrFalse,
                Mark = 7,
                Choices = new List<string> { "True", "False" }
            },
            new Question
            {
                Title = "The keyword 'var' in C# means dynamic typing.",
                QuestionType = QuestionType.TrueOrFalse,
                Mark = 7,
                Choices = new List<string> { "True", "False" }
            },
            new Question
            {
                Title = "All .NET applications must have at least one Main() method.",
                QuestionType = QuestionType.TrueOrFalse,
                Mark = 7,
                Choices = new List<string> { "True", "False" }
            },

            // ========== MULTIPLE CHOICE QUESTIONS ==========
            new Question
            {
                Title = "Which of the following is NOT a C# access modifier?",
                QuestionType = QuestionType.MCQ,
                Mark = 10,
                Choices = new List<string> { "A) public", "B) private", "C) protected", "D) include" }
            },
            new Question
            {
                Title = "Which keyword is used to handle exceptions in C#?",
                QuestionType = QuestionType.MCQ,
                Mark = 10,
                Choices = new List<string> { "A) throw", "B) try", "C) catch", "D) finally" }
            },
            new Question
            {
                Title = "Which of the following collections guarantees unique elements?",
                QuestionType = QuestionType.MCQ,
                Mark = 10,
                Choices = new List<string> { "A) List", "B) Dictionary", "C) HashSet", "D) Queue" }
            },
            new Question
            {
                Title = "Which LINQ method is used to filter a sequence?",
                QuestionType = QuestionType.MCQ,
                Mark = 10,
                Choices = new List<string> { "A) Select", "B) Where", "C) OrderBy", "D) GroupBy" }
            },
            new Question
            {
                Title = "Which keyword is used to define a constant value in C#?",
                QuestionType = QuestionType.MCQ,
                Mark = 10,
                Choices = new List<string> { "A) const", "B) static", "C) readonly", "D) final" }
            },
            
        };
        }
    }
}
