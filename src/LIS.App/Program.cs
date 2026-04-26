using LIS.Core;

namespace LIS.App
{

    public class Program
    {
        static void Main()
        {
            var longestSubsequence = new LongestSubsequence();
            Console.WriteLine("Enter a sequence of integers separated by spaces:");
            string input = Console.ReadLine() ?? string.Empty;

            //if (!IsValidInput(input))
            //{
            //    Console.WriteLine("Invalid input. Please enter a sequence of integers separated by spaces (Example: 2 3 1 4 5 6).");
            //    return;
            //}

            string result = longestSubsequence.GetLongestSubsequence(input);
            Console.WriteLine($"Longest increasing subsequence: {result}");
        }

        public static bool IsValidInput(string input)
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