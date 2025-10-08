using DependancyInversion.After;

namespace DependancyInversion
{

    // definition 
    // => High-level modules should not depend on low-level modules. Both should depend on abstractions.
    //Abstractions should not depend on details.Details should depend on abstractions.

    public class EntryPoint
    {
        static void Main()
        {
            BeforeApplyDependancyInversion();
            AfterApplyDependancyInversion();
        }

        public static void BeforeApplyDependancyInversion()
        {
            var clients =  DependancyInversion.Before.Repository.GenerateClients;
            var notificationService = new Before.NotificationService();

            Console.WriteLine($"\n\n{new string('-', 10)}" +
               $"  Before Apply Dependancy Inversion " +
               $"{new string('-', 10)}\n\n");
            notificationService.Notify(clients);
        }

        public static void AfterApplyDependancyInversion()
        {
            var clients = DependancyInversion.After.Repository.GenerateClients;
            
            Console.WriteLine($"\n\n{new string('-',10)}" +
                $"  After Apply Dependancy Inversion " +
                $"{new string('-',10)}\n\n");
            
            foreach(var client in clients)
            {
                var mails = new List<IMessageService>()
                {
                    new SMSService(){ PhoneNo = client.PhoneNO },
                    new EmailService() { ClientEmail = client.Email}
                };

                var notificationService = new After.NotificationService(mails);
                notificationService.Notify();
            }
        }
    }
}