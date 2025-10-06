using OpenClosedPrinciple.Before;

namespace OpenClosedPrinciple.After
{
    public class MCQsQuestion : Question
    {
        public List<string> Choices { set; get; } = new List<string>();

        public override void Print()
        {
            foreach (var choice in Choices)
            {
                Console.WriteLine("   " + choice);
            }
        }
    }
}
