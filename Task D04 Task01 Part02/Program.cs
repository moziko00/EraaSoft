using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_D04_Part02
{
    internal class Program
    {
        public enum MenuOption
        {
            Withdraw = 0,
            Deposite = 1,
            Print = 2,
            Quit = 3
        }
        static void Main(string[] args)
        {


        }
        public static int GetUserSelection()
        {
            bool isValidSelection = false;
            int userSelection = 0;

            do
            {
                Console.WriteLine("Please select an option (1-4):");
                string input = Console.ReadLine();

                // Attempt to convert the input to an integer
                if (int.TryParse(input, out int selection))
                {
                    // Check if the selection is within the valid range
                    if (selection >= 1 && selection <= 4)
                    {
                        userSelection = selection;
                        isValidSelection = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection. Please enter a number between 1 and 4.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (!isValidSelection);

            return userSelection;
        }

        private static void DoDeposite(Account account)
        {
            switch (account)
            {
                case MenuOption.Deposite:
                    DoDeposite(account);
                    break;
            }
        }
    }
}
