// By iteration (Distribution Method)
public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> subsets = [[]];

        foreach (var num in nums) {
            var newSubsets = new List<List<int>>();

            foreach (var subset in subsets) {
                var newSubset = new List<int>(subset);
                newSubset.Add(num);
                newSubsets.Add(newSubset);
            }

            subsets.AddRange(newSubsets);
        }

        return subsets;
    }
}
