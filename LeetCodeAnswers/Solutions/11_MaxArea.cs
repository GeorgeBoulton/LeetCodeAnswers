namespace LeetCodeAnswers.Solutions;

public partial class Solution
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = 0;

        while (left < right)
        {
            var containerHeight = Math.Min(height[left], height[right]);
            var containerWidth = right - left;
            
            var currentArea = containerHeight * containerWidth;
            maxArea = Math.Max(maxArea, currentArea);
            
            if (height[left] < height[right]) left++;
            else right--;
        }
        
        return maxArea;
    }
}