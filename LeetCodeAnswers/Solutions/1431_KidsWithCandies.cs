namespace LeetCodeAnswers.Solutions;

public partial class Solution
{
    // 1431. Kids With the Greatest Number of Candies
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var maxCandies = candies.Max();
        var kidsLength = candies.Length;
        
        var extras = new bool[kidsLength];

        for (var i = 0; i < kidsLength; i++)
        {
            extras[i] = candies[i] + extraCandies >=  maxCandies;
        }

        return extras;
    }
}