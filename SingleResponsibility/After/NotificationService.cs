namespace SingleResponsibility.After
{
    internal class NotificationService
    { 
    
        public void SendMail(BankAccount account,string transactionMessage)
        {
            Console.WriteLine(@$"
                                 ------------------------------------------------------------
                                                    🏦  Fake Bank Transaction Notice
                                 ------------------------------------------------------------
                                 To: {account.Email}
                                 Message: {transactionMessage}
                                 Date: {DateTime.Now:MMMM dd, yyyy - HH:mm:ss}
                                 
                                 ✅ Your transaction has been successfully processed.
                                 Thank you for choosing Fake Bank!
                                 ------------------------------------------------------------
                                 ");
        }
    
    }

}
