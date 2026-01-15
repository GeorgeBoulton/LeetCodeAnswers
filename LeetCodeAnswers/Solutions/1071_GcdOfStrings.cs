namespace LeetCodeAnswers;


public partial class Solution
{
    // 1071. Greatest Common Divisor of Strings
    public string GcdOfStrings(string str1, string str2)
    {
        // If strings not made from same repeating pattern, concatenating both ways will never be equal.
        if (str1 + str2 != str2 + str1) return string.Empty;
        
        var length = GreatestCommonDenominator(str1.Length, str2.Length);
        return str1.Substring(0, length);
    }
    
    private static int GreatestCommonDenominator(int a, int b)
    {
        while (b != 0)
        {
            var remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}