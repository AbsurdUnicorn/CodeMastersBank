namespace CodeMastersBank;

public class SavingsAccount : BankAccount
{
    
    public decimal InterestRate { get; set; }


    
    public SavingsAccount(string name, decimal balance,
                          string currency, string accountNumber,
                          decimal interestRate)
        : base(name, balance, currency, accountNumber)
    {
        InterestRate = interestRate;
    }


    // Calculate interest
    public decimal CalculateInterest(decimal amount)
    {
        if (amount <= 0)
        {
            return 0;
        }

        decimal interest = amount * (InterestRate / 100m);

        return interest;
    }
}
