public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        var acc = 1;

        for (int i = 0; i < nums.Length; i++) {
            result[i] = acc;
            acc = acc * nums[i];
        }

        acc = 1; // reset

        for (int i = (nums.Length - 1); i >= 0; i--) {
            result[i] *= acc;
            acc = acc * nums[i];
        }    

        return result;
    }
}
