namespace OpenClosedPrinciple.After
{
    public class TrueOrFalaseQuestion : Question
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
