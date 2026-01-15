namespace LeetCodeAnswers.Solutions;

public partial class Solution
{
    // 345. Reverse Vowels of a String
    public string ReverseVowels(string s)
    {
        if (string.IsNullOrEmpty(s)) return s;

        var chars = s.ToCharArray();

        var leftPointer = 0;
        var rightPointer = chars.Length - 1;

        while (leftPointer < rightPointer)
        {
            // If left pointer not a vowel move it up. If right pointer not a vowel move it down.
            while (leftPointer < rightPointer && !IsVowel(chars[leftPointer])) leftPointer++;
            while (leftPointer < rightPointer && !IsVowel(chars[rightPointer])) rightPointer--;

            if (leftPointer < rightPointer)
            {
                (chars[leftPointer], chars[rightPointer]) = (chars[rightPointer], chars[leftPointer]);

                leftPointer++;
                rightPointer--;
            }
        }
        
        return new string(chars);
    }

    private static bool IsVowel(char c)
    {
        c = char.ToLowerInvariant(c);
        
        return c is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}