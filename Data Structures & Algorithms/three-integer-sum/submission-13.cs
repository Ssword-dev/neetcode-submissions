public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var triplets = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++) {
            if (i != 0 && nums[i - 1] == nums[i]) continue;

            var target = -nums[i];

            var j = i+1;
            var k = nums.Length - 1;

            while (j < k) {
                var pairSum = nums[j] + nums[k];

                if (
                    pairSum == target
                ) {
                    triplets.Add([nums[i], nums[j], nums[k]]);
                    j++;
                    k--;

                    while (j < k && nums[j] == nums[j - 1]) j++;
                    while (j < k && nums[k] == nums[k + 1]) k--;
                } else if (pairSum < target) {
                    j++;
                } else {
                    k--;
                }
            }
        }

        return triplets;
    }
}
