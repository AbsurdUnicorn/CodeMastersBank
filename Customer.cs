using System.Security.Principal;

namespace CodeMastersBank;

public class Customer : User
{
    private List<BankAccount> accounts = new List<BankAccount>();

   
    
    public Customer()
        :base(username, pincode)
    {
        BankAccount account1 = new BankAccount();
    }
    
    private void OpenAccount()
    {
        Console.WriteLine("Skapa konto: ");

        while (true)
        {
            switch
        }
    }
    public void WithDraw()
    {

    }
    public void Transfer()
    {

    }
    public void Deposit()
    {

    }
    public void ViewAccounts()
    {

    }
}
