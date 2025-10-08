namespace DependancyInversion.Before
{
    // notification is high level modules
    // and smsService and EmailService is low level modules 
    // this high level modules should not be depend on low level modules 
    // and should be depend on abstraction 
    public class NotificationService
    {
        private readonly SMSService _smsService;
        private readonly EmailService _emailService;
        public NotificationService()
        {
            _smsService = new SMSService();
            _emailService = new EmailService();
        }

        public void Notify(List<Client> clients)
        {
            foreach(var client in clients)
            {
                _emailService.Send(client);
                _smsService.Send(client);
            }
        }
    }
}
