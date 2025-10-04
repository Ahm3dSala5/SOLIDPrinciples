namespace SingleResponsibility.After
{
    internal class BankAccountService
    {
        private readonly BankAccount _bankAccount;

        public BankAccountService(BankAccount bankAccount)
        {
            this._bankAccount = bankAccount;
        }

        public void Deposit(BankAccount account, int amount)
        {
            account.Balance += amount;
            var notificationService = new NotificationService();
            notificationService.SendMail(account, "Deposit Successfully");
        }

        public void Withdraw(BankAccount account, int amount)
        {
             var notificationService = new NotificationService();

            if (account.Balance < Math.Abs(amount))
            {
                notificationService.SendMail(account, "Sorry You Not Have enough money");
            }
            else
            {
                account.Balance -= amount;
                notificationService.SendMail(account, "Withdraw Successfully");
            }
        }
    }

}
