namespace SingleResponsibility.Before
{

    // 1 :: Rich domain model(preferred in ddd) definition:
    //a rich domain model puts data and behavior together inside the same entity or aggregate.
    //the domain model encapsulates business rules, and external code just calls the right methods.

    // =====================================================================//

    // 2 :: Anemic Domain Model(Bad Practice in DDD) definition:
    //an anemic domain model is one where your domain objects(entities) only hold data(properties) — but contain no business logic.
    //All the logic instead lives in services or controllers.


    // then this call rich domain model becuse => contins both properties and methos 
    // but this vaiolate single responsability principle becuse this class do then take
    internal class BankAccount
    {
        public BankAccount(string name, string email, decimal balance)
        {
            this.Balance = balance;
            this.Name = name;
            this.Email = email;
        }

        public string Name { set; get; }
        public string Email { set; get; }
        public decimal Balance { set; get; }

        // if user add negative value then system will withdraw money else will deposit
        public void Transaction(int amount) // this for deposit and withdraw
        {
            string transactionMessage = "";

            if(amount<0)
            {
                if(Balance < Math.Abs(amount))
                {
                    transactionMessage = "Sorry You Not Have enguh money";
                }
                else
                {
                    Balance -= amount;
                    transactionMessage = "Withdraw Successfully";
                }

            } else
            {
                Balance += amount;
                transactionMessage = "Deposit Successfully";
            }

            Console.WriteLine(@$"
                                 ------------------------------------------------------------
                                                    🏦  Fake Bank Transaction Notice
                                 ------------------------------------------------------------
                                 To: {Email}
                                 Message: {transactionMessage}
                                 Date: {DateTime.Now:MMMM dd, yyyy - HH:mm:ss}
                                 
                                 ✅ Your transaction has been successfully processed.
                                 Thank you for choosing Fake Bank!
                                 ------------------------------------------------------------
                                 ");

        }
    }
}
