namespace LeetCodeAnswers.Solutions;

public partial class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;
        
        var sIndex = 0;

        for (var tIndex = 0; tIndex < t.Length; tIndex++)
        {
            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }
            
            if (sIndex == s.Length) return true;
        }

        return false;
    }
}