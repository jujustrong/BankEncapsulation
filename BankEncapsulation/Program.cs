namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount();
            account1.GetBalance();
            Console.WriteLine();
            Console.Write("Would you like to deposit to your bank account? (y/n) ");
            var answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                account1.Deposit();
            }
            else
            {
                account1.GetBalance();
                Console.WriteLine("Thanks for stopping by!");
            }
        }
    }
}
