namespace DependancyInversion.Before
{
    public class SMSService
    {
        public void Send(Client client)
        {
            Console.WriteLine($"SMS Message To {client.PhoneNO}\n");
            Console.WriteLine(new string('-', 50));
        }
    }
}
