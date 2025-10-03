namespace SOLIDPrinciples.LIskovSubstitutions
{
    public abstract class BankAccount
    {
        public BankAccount(string name, decimal balance)
        {
            this.Name = name;
            this.Balance = balance;
        }

        protected string Name { set; get; }
        protected decimal Balance { set; get; }

        public abstract void Deposit(decimal amount);
    }
}
