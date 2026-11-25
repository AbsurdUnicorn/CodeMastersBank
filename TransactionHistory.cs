namespace CodeMastersBank;

public class TransactionHistory
{
    private static List<Transfer> transfers;

    public static void AddTransfer(Transfer transfer)
    {
        transfers.Add(transfer);
    }

    public static void AddEvent(string description)
    {
        
    }

    public static List<Transfer> GetUserTransfers()
    {
        return transfers;
    }
}
