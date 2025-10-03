namespace SOLIDPrinciples.LIskovSubstitutions
{
    public abstract class RegularBankAccount : BankAccount
    {
        public RegularBankAccount(string name, decimal balance)
                    : base(name, balance)
        {
            this.Name = name;
            this.Balance = balance;
        }
        public string Name { set; get; }
        public decimal Balance { set; get; }
        public abstract void Withdraw(decimal amount);
    }
}



