public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var lookupTable = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            var comp = target - num;

            if (lookupTable.TryGetValue(target - num, out var compIndex)) {
                return [compIndex, i];
            }

            lookupTable.TryAdd(num, i);
        }

        return [-1, -1];
    }
}
