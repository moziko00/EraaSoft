using System.Xml.Linq;

public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount(string name = "Unnamed Savings Account", double balance = 0.0, double interestRate = 0.0)
        : base(name, balance)
    {
        InterestRate = interestRate;
    }

    public override bool Deposit(double amount)
    {
        // Apply interest before deposit
        ApplyInterest();
        return base.Deposit(amount);
    }

    public override bool Withdraw(double amount)
    {
        // Apply interest before withdrawal
        ApplyInterest();
        return base.Withdraw(amount);
    }

    public static void Display(List<SavingsAccount> accounts)
    {
        Console.WriteLine("\n=== Savings Accounts ======================================");
        foreach (var acc in accounts)
        {
            Console.WriteLine(acc);
        }
    }

    public static void Deposit(List<SavingsAccount> accounts, double amount)
    {
        Console.WriteLine("\n=== Depositing to Savings Accounts =========================");
        foreach (var acc in accounts)
        {
            if (acc.Deposit(amount))
                Console.WriteLine($"Deposited {amount} to {acc}");
            else
                Console.WriteLine($"Failed Deposit of {amount} to {acc}");
        }
    }

    public static void Withdraw(List<SavingsAccount> accounts, double amount)
    {
        Console.WriteLine("\n=== Withdrawing from Savings Accounts ======================");
        foreach (var acc in accounts)
        {
            if (acc.Withdraw(amount))
                Console.WriteLine($"Withdrew {amount} from {acc}");
            else
                Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
        }
    }

    private void ApplyInterest()
    {
        balance += balance * InterestRate / 100;
    }

    public override string ToString()
    {
        return $"[Savings Account: {name}, Balance: {balance}, Interest Rate: {InterestRate}%]";
    }
}
