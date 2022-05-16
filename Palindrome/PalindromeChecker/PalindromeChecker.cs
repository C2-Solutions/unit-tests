using System.Linq;
using System.Text.RegularExpressions;

namespace Palindromes
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string InputString)
        {
            string StringToCheck = Regex.Replace(InputString.ToLower(), @"[^a-z]+", "");
            return StringToCheck.SequenceEqual(StringToCheck.Reverse());
        }
    }
}
