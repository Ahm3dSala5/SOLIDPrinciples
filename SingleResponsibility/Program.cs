public class EnteryPoint
{
    public static void Main()
    {
        BeforeApplySingleResponsibility();

        Console.WriteLine("After Appling Single Responsibility");

        AfteApplySingleResponsibility();
    }


    static void BeforeApplySingleResponsibility()
    {
        var account = new SingleResponsibility.Before.BankAccount("Ahmed", "ahmed557slah@gmail.com", 4000);
        account.Transaction(5900);
    }


    static void AfteApplySingleResponsibility()
    {
        var account = new SingleResponsibility.
            After.BankAccount("Ahmed", "ahmed557slah@gmail.com", 4000);
        
        var transactionService = new SingleResponsibility.
            After.BankAccountService(account);
        transactionService.Withdraw(account, 5900);
    }
}

