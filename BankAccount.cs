namespace CodeMastersBank;

public class BankAccount
{   
    public string Name { get; set; }

    // Private setter for Balance to prevent external modification
    public decimal Balance { get; private set; }
    public string Currency { get; set; }
    public string AccountNumber { get; set; }


    // Constructor
    public BankAccount(string name, decimal balance,
                       string currency, string accountNumber)
    {
        Name = name;
        Balance = balance;
        Currency = currency;
        AccountNumber = accountNumber;
    }


    
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return;
        }

        Balance += amount;
    }


    
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }
}
