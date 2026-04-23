public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new HashSet<int>();

        foreach (var num in nums) {
            if (!seen.Contains(num)) {
                seen.Add(num);
            }

            else {
                return true;
            }
        }

        return false;
    }
}