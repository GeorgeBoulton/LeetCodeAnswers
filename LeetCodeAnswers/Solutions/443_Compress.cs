namespace LeetCodeAnswers.Solutions;

public partial class Solution
{
    // 443. String Compression
    public int Compress(char[] chars)
    {
        var length = chars.Length;
        var writeIndex = 0;
        var readIndex = 0;
        
        while (readIndex < length)
        {
            var currentChar = chars[readIndex];
            var start = readIndex;

            // Keep counting until the next char no longer matches the current char.
            while (readIndex < length && chars[readIndex] == currentChar) readIndex++;
            // Get the difference between where we read up to and where we started. This is the number of chars.
            var successiveCharsCount = readIndex - start;
            
            chars[writeIndex++] = currentChar;

            if (successiveCharsCount <= 1) continue;
            
            // Add the successive chars count as individual chars.
            foreach (var digit in successiveCharsCount.ToString()) chars[writeIndex++] = digit;
        }
        
        return writeIndex;
    }
}