namespace SOLIDPrinciples.LIskovSubstitutions
{
    // subclass must be substitutable for its base class
    // if S is a subtype of T, then objects of type T may be replaced with objects of type S
    public class Program
    {
        public static void Main()
        {
            // saving account
            var userBalnkAccount = new SavingAccount("Ahmed",3000);
            userBalnkAccount.Deposit(2000);
            userBalnkAccount.Withdraw(1000);
            Console.WriteLine($"Saving Balance = {userBalnkAccount.Balance}");

            // check account
            var userCheckAccount = new CheckAccount("Mohamed", 5000);
            userCheckAccount.Deposit(2000);
            userCheckAccount.Withdraw(1000);
            Console.WriteLine($"User Balance = {userCheckAccount.Balance}");

            // fixed account
            // user cant wothdrawal
            var userFixedAccount = new FixedAccount("Ali", 10000);
            userFixedAccount.Deposit(2000);
        }
    }
}
