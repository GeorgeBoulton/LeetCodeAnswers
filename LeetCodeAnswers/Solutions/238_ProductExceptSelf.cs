using System.ComponentModel;

namespace LeetCodeAnswers.Solutions;

public partial class Solution
{
    // 238. Product of Array Except Self
    public int[] ProductExceptSelf(int[] nums)
    {
        var products = GetPrefixProducts(nums);
        
        return GetSuffixProducts(nums, products);
    }

    private int[] GetPrefixProducts(int[] nums)
    {
        var products = new int[nums.Length];
        // Nothing to the left of i = 0 so product is 1
        products[0] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            // products[i] = (product of everything left of i)
            products[i] = products[i - 1] * nums[i - 1];
        }

        return products;
    }

    private int[] GetSuffixProducts(int[] nums, int[] products)
    {
        // Nothing to the right of i = max so product is 1
        int suffix = 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            products[i] *= suffix;  // multiply by product of everything right of i
            suffix *= nums[i];      // update suffix for next index to the left
        }

        return products;
    }
}