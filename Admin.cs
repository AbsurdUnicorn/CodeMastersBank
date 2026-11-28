using static CodeMastersBank.User;

namespace CodeMastersBank;

public class Admin : User
{
    private List<User> users = new List<User>();
    
    public void AddCustomer()
    {
        Console.WriteLine("Skapa ny användare:\n");
        Console.Write("Skriv in nytt användarnamn: ");
        string userUsername = Console.ReadLine();

        

        while (true)
        {
            Console.Write("Skriv in pinkod: ");
            string userPincodeCheck1 = Console.ReadLine();

            Console.Write("Skriv in pinkoden igen: ");
            string userPincodeCheck2 = Console.ReadLine();

            if (userPincodeCheck1 != userPincodeCheck2)
            {
                Console.WriteLine("Pinkoderna matchade inte! ");
            }
            else
            {
                string newUserPincode = userPincodeCheck2;
                Console.WriteLine("Användare skapad!\n");
                Console.WriteLine("Tryck ENTER för att fortstätta");
                Console.ReadKey();
                break;
            }
        }
        new Customer()

    }
    private void AddAdmin()
    {

    }

    public void DeleteUser(User user)
        
    {
        

    }
    public void ViewAllUsers()
    {

    }
    public User FindUser(User user)
    {
        return user;
    }
}
