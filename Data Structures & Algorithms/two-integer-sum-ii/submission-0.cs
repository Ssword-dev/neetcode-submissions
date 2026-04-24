public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var indexes = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++) {
            if (indexes.TryGetValue(target - numbers[i], out var complementaryIndex)) {
                return [complementaryIndex+1, i+1];
            }

            indexes.Add(numbers[i], i);
        }

        return [-1, -1]; // just to satisfy the compiler otherwise it will error.
    }
}
