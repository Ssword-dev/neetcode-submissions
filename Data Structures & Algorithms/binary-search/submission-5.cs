public class Solution {
    public int Search(int[] nums, int target) {
        var l = 0;
        var r = nums.Length - 1;

        while (l <= r) {
            var m = (l+r)/2; // naturally floors.
            
            if (nums[m] == target) {
                return m;
            }

            else if (nums[m] < target) {
                l = m + 1;
            }

            else {
                r = m - 1;
            }
        }

        return -1;
    }
}
