using LIS.Core;

namespace LIS.App
{

    public class Program
    {
        static void Main()
        {
            var longestSubsequence = new LongestSubsequence();

            while (true)
            {
                
                Console.WriteLine("Enter a sequence of integers separated by spaces: or type 'q' to quit: ");
                string input = Console.ReadLine() ?? string.Empty;

                // Handle quit condition
                if (input.Trim().Equals("q", StringComparison.OrdinalIgnoreCase))
                { 
                   Console.WriteLine("Exiting the application. Goodbye!");
                   break;
                }

                // Handle invalid input
                if (!IsValidInput(input))
                {
                    Console.WriteLine("Invalid input. Please enter a sequence of integers separated by spaces (Example: 2 3 1 4 5 6).");
                    continue;
                }

                try 
                {
                    string result = longestSubsequence.GetLongestSubsequence(input);
                    Console.WriteLine($"Longest increasing subsequence: {result}");
                }
                catch (Exception ex)
                { 
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                // Add an empty line for better readability between iterations
                Console.WriteLine(); 
            }            
        }

        private static bool IsValidInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!char.IsDigit(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}