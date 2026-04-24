public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hs = new HashSet<int>(nums);
        var longestConsecutiveSequenceLength = 0;

        foreach (var num in nums) {
            if (hs.Contains(num - 1)) continue;

            var cur = num + 1;
            var sequenceLength = 1;

            while (hs.Contains(cur)) {
                cur = cur + 1;
                sequenceLength++;
            }

            if (sequenceLength > longestConsecutiveSequenceLength) {
                longestConsecutiveSequenceLength = sequenceLength;
            }
        }

        return longestConsecutiveSequenceLength;
    }
}
