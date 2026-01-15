using System.Text;

namespace LeetCodeAnswers.Solutions;

public partial class Solution 
{
    // 1768. Merge Strings Alternately
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
}