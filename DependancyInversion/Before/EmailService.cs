namespace DependancyInversion.Before
{
    public class EmailService
    {
        public void Send(Client client)
        {
            Console.WriteLine($"Email Message To {client.Email}\n");
            Console.WriteLine(new string('-',50));
        }
    }
}
