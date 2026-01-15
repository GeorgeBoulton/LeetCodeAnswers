using System.Text;

namespace LeetCodeAnswers;

public class Solution {
    
    #region 1768. Merge Strings Alternately
    public string MergeAlternately(string word1, string word2)
    {
        var stringBuilder = new StringBuilder();
        var maxLength = Math.Max(word1.Length, word2.Length);

        for (var i = 0; i < maxLength; i++)
        {
            if (i < word1.Length)
            {
                stringBuilder.Append(word1[i]);
            }
            if (i < word2.Length)
            {
                stringBuilder.Append(word2[i]);
            }
        }
        
        return stringBuilder.ToString();
    }
    #endregion
    
    #region 1071. Greatest Common Divisor of Strings
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
    #endregion

    #region 1431. Kids With the Greatest Number of Candies
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        
        
    }

    #endregion
}