namespace LIS.Core;

/// <summary>
/// The LongestSubsequence class provides functionality to find the longest increasing 
/// subsequence from a given input string of space-separated integers.
/// </summary>
public class LongestSubsequence
{

    /// <summary>
    /// Finds the longest contiguous subsequence of integers in the input string.
    /// </summary>
    /// <param name="inputStr">A string containing a sequence of integers separated by spaces. Cannot be null, empty, or consist only of
    /// whitespace.</param>
    /// <returns>A string representing the longest contiguous subsequence of integers found in the input. Returns an empty string
    /// if the input is null, empty, or contains only whitespace.</returns>
    public string GetLongestSubsequence(string inputStr)
    {

        // Validate input for null, empty, or whitespace-only string.
        if (string.IsNullOrWhiteSpace(inputStr))
            return string.Empty;

        try
        {
            // Parse the input string into an array of integers, removing any extra spaces.
            var inputArray = inputStr.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            // Initialize variables to track the longest subsequence and the current subsequence.
            int maxLength = 1, currentLength = 1;
            int maxStartIndex = 0, currentStartIndex = 0;

            // Iterate through the array to find the longest increasing subsequence.
            for (int i = 1; i < inputArray.Length; i++)
            {
                // Check if the current element is greater than the previous element to continue the subsequence.
                if (inputArray[i] > inputArray[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    currentStartIndex = i;
                    currentLength = 1;
                }

                // Update the maximum length and starting index if the current subsequence is longer.
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStartIndex = currentStartIndex;
                }
            }

            // Return the longest subsequence as a space-separated string.
            return string.Join(" ", inputArray.Skip(maxStartIndex).Take(maxLength));
        }
        catch (FormatException ex)
        { 
          throw new FormatException("Invalid input. Please enter a sequence of integers separated by spaces (Example: 2 3 1 4 5 6).", ex);
        }        
    }
}
