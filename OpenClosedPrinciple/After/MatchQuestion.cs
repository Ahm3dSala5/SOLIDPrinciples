namespace OpenClosedPrinciple.After
{
    public class MatchQuestion : Question
    {
        public Dictionary<string, string> Pairs { set; get; } = new Dictionary<string, string>();
        public override void Print()
        {
            foreach(var item in Pairs)
            {
                Console.WriteLine(item.Key+"     "+item.Value);
            }
        }
    }
}
