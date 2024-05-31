using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_D01
{
    

    public class MenuHelper
    {
        public static MenuOption GetUserSelection()
        {
            MenuOption userSelection;
            bool isValidSelection = false;

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
                        userSelection = (MenuOption)selection;
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
    }
}
