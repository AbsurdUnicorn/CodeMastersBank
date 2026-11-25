namespace CodeMastersBank;

public class Transfer
{
    public int FromAccountNum; 
    public int ToAccountNum;
    public decimal Amount;
    public string FromCurrency; // Gathered from the account number
    public string ToCurrency; // Gathered from the account number
    public DateTime Date;
    public string Status;

    public Transfer(int fromAccountNum, int toAccountNum, decimal amount)
    {
        FromAccountNum = fromAccountNum;
        ToAccountNum = toAccountNum;
        Amount = amount;
        // FromCurrency - Get the currency using the account number and checking the object connected to that number
        // ToCurrency = Get the currency using the account number and checking the object connected to that number
        Date = DateTime.Now;
        Status = "Processing";
    }
}
