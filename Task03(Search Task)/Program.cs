namespace Search_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            try
            {
                Console.WriteLine("Enter a list of integers separated by spaces:");
                string input = Console.ReadLine();

                // Split the input string into an array of strings representing each number
                string[] numbersAsString = input.Split(' ');

                // Create a HashSet to store unique numbers
                List<int> uniqueNumbers = new List<int>();

                foreach (string numberAsString in numbersAsString)
                {
                    int number = int.Parse(numberAsString);

                    if (uniqueNumbers.Contains(number))
                    {
                        throw new ArgumentException("Duplicate numbers are not allowed.");
                    }

                    uniqueNumbers.Add(number);
                }

                Console.WriteLine("All numbers are unique.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter integers separated by spaces.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Task 2
            try
            {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();

                // Call the method to check for vowels
                CheckForVowels(input);

                Console.WriteLine("The string contains vowels.");
            }
            catch (NoVowelsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            static void CheckForVowels(string input)
            {
                // Convert the input string to lowercase for case-insensitive comparison
                string lowercaseInput = input.ToLower();

                // Define a string containing all vowels
                string vowels = "aeiou";

                // Iterate through each character in the input string
                foreach (char c in lowercaseInput)
                {
                    // Check if the character is a vowel
                    if (vowels.Contains(c))
                    {
                        // If a vowel is found, return from the method
                        return;
                    }
                }

                // If no vowels are found, throw an exception
                throw new NoVowelsException("The string does not contain any vowels.");
            }

            #endregion
        }
    }
}