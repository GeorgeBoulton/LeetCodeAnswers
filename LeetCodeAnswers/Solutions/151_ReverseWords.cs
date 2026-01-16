namespace LeetCodeAnswers.Solutions;

public partial class Solution 
{
    // 151. Reverse Words in a String
    public string ReverseWords(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        var leftPointer = 0;
        var rightPointer = words.Length - 1;

        while (leftPointer < rightPointer)
        {
            (words[leftPointer], words[rightPointer]) = (words[rightPointer], words[leftPointer]);
            
            leftPointer++;
            rightPointer--;
        }

        return string.Join(" ", words);
    }
}