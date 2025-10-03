namespace SOLIDPrinciples.LIskovSubstitutions
{
    public class FixedAccount : BankAccount
    {
        public FixedAccount(string name, decimal balance)
            : base(name, balance)
        {

        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException("Amount Canot Be zero or negative value");

            this.Balance += amount;
        }
    }

}