public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
       return nums
            .GroupBy(n => n)
            .Select(g => KeyValuePair.Create(g.Key, g.Count()))
            .OrderByDescending(kv => kv.Value)
            .Select(kv => kv.Key)
            .Take(k)
            .ToArray();
    }
}
