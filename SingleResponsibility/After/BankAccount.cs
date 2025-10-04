namespace SingleResponsibility.After
{
    // in this module we will apply single responsibility principle
    // each class must have one reason to change
    // each class or moule or method must do one thing

    internal class BankAccount
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public decimal Balance { set; get; }
        public BankAccount(string name, string email, decimal balance)
        {
            this.Balance = balance;
            this.Name = name;
            this.Email = email;
        }
    }

}
