namespace LeetCodeAnswers.Solutions;

public partial class Solution 
{
    public void MoveZeroes(int[] nums)
    {
        var insertPosition = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            // When element isn't zero
            if (nums[i] != 0)
            {
                // Move it to the end of the non-zero collection at the start of the array
                (nums[insertPosition], nums[i]) = (nums[i], nums[insertPosition]);
                insertPosition++;
            }
        }
    }
}