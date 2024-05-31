using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    public class TrustAccount: Account
    {
        private const int MaxWithdrawalsPerYear = 3;
        private const double MaxWithdrawalPercentage = 0.20;
        private const double BonusThreshold = 5000.00;
        private const double BonusAmount = 50.00;

        private int withdrawalsThisYear;

        public double InterestRate { get; set; }

        public TrustAccount(string name = "Unnamed Trust Account", double balance = 0.0, double interestRate = 0.0)
            : base(name, balance)
        {
            InterestRate = interestRate;
            withdrawalsThisYear = 0;
        }

        public override bool Deposit(double amount)
        {
            // Apply bonus for large deposits
            if (amount >= BonusThreshold)
            {
                amount += BonusAmount;
            }
            return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            // Check withdrawal limits
            if (withdrawalsThisYear < MaxWithdrawalsPerYear && amount <= balance * MaxWithdrawalPercentage)
            {
                withdrawalsThisYear++;
                return base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Withdrawal limit exceeded or amount exceeds the allowed percentage of the balance.");
                return false;
            }
        }
        public static void Display(List<TrustAccount> accounts)
        {
            Console.WriteLine("\n=== Trust Accounts ========================================");
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc);
            }
        }
        public static void Deposit(List<TrustAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Trust Accounts ===========================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }
        public static void Withdraw(List<TrustAccount> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Trust Accounts ========================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }


        public override string ToString()
        {
            return $"[Trust Account: {name}, Balance: {balance}, Interest Rate: {InterestRate}%]";
        }
    }
}
