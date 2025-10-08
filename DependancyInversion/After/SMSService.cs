namespace DependancyInversion.After
{
    public class SMSService : IMessageService
    {
        public string PhoneNo { set; get; }
        public void Send()
        {
            Console.WriteLine($"SMS Message To {PhoneNo}\n");
            Console.WriteLine(new string('-', 50));
        }
    }
}
