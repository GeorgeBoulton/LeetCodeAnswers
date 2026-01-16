namespace LeetCodeAnswers.Solutions;

public partial class Solution 
{
    // 334. Increasing Triplet Subsequence
    public bool IncreasingTriplet(int[] nums)
    {
        var first = int.MaxValue;
        var second = int.MaxValue;

        foreach (var num in nums)
        {
            if (num <= first) first = num;
            else if (num <= second) second = num;
            else return true;
        }

        return false;
    }
    
    // nums = [2,1,5,0,4,6] should return true. 1, 4, 6
    // After pass 1: num = 2 → first = 2, second = ∞
    // After pass 2: num = 1 → first = 1, second = ∞
    // After pass 3: num = 5 → first = 1, second = 5
    // After pass 4: num = 0 → first = 0, second = 5
    // After pass 5: num = 4 → first = 0, second = 4
    // After pass 6: num = 6 → 6 > second → triplet found (0 < 4 < 6)
}