namespace DependancyInversion.After
{
    public class EmailService : IMessageService
    { 
        public string ClientEmail { set; get; }

        public void Send()
        {
            Console.WriteLine($"Email Message To {ClientEmail}\n");
            Console.WriteLine(new string('-',50));
        }
    }
}
