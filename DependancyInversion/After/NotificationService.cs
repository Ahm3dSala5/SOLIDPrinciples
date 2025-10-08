namespace DependancyInversion.After
{
    // notification is high level modules
    // and smsService and EmailService is low level modules 
    // this high level modules should not be depend on low level modules 
    // and should be depend on abstraction 
    public class NotificationService
    {
        private readonly List<IMessageService> _messageService;
        public NotificationService(List<IMessageService> messageService)
        {
            this._messageService = messageService;
        }

        public void Notify()
        {
            foreach(var message in _messageService)
            {
                message.Send();
            }
        }
    }
}
