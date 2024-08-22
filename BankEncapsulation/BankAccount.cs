namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 0;
    public double Deposit()
    {
        var i = true;
        while (i == true)
        {
            Console.Write("How much would you like to deposit? ");
            var a = double.TryParse(Console.ReadLine(), out var amount);
                
            while (a == false)
            {
                Console.WriteLine("Please enter a valid number: ");
                a = double.TryParse(Console.ReadLine(), out amount);
            }

            Console.WriteLine($"Depositing ${amount} into account...");
            _balance += amount;
        
            Console.WriteLine();
            Console.Write("Would you like to make another deposit? (y/n) ");
            var exit = Console.ReadLine();
            if (exit.ToLower() != "y")
            {
                GetBalance();
                Console.WriteLine("Thank you for stopping by!");
                i = false;
            }
        }
        return _balance;
        
    }
    
    public void GetBalance()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Current Balance: {_balance}");
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
}