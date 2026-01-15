namespace LeetCodeAnswers.Solutions;

public partial class Solution 
{
    // 605. Can Place Flowers
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0) return true;
        
        for (var i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 1) continue;

            var leftEmpty = i == 0 ||  flowerbed[i - 1] == 0;
            var rightEmpty = i == flowerbed.Length - 1 ||  flowerbed[i + 1] == 0;

            if (!leftEmpty || !rightEmpty) continue;
            
            // Plant the flower
            flowerbed[i] = 1;
            n--;
            
            if (n == 0) return true;
        }

        return false;
    }
}