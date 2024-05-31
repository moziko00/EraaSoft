namespace Task_D01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200000, "Jacks Account");

            account.Print();
            account.Deposite(100);
            account.Print();



            account.Print();
            account.Withdraw(100);
            account.Print();


            account.Print();
            account.Withdraw(29000);
            account.Print();

        }
    }
}
