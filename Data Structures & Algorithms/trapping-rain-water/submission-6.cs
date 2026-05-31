
public class Solution {
    public int Trap(int[] height) {
        // O(n) space
        var tallestFromLeftSide = new int[height.Length];
        var tallestFromRightSide = new int[height.Length];

        var currentTallest = 0;

        for(int i = 1; i < height.Length; i++) {
            tallestFromLeftSide[i] = height[i - 1] > height[currentTallest] ? i - 1 : currentTallest;
            currentTallest = tallestFromLeftSide[i];
        }

        currentTallest = height.Length - 1;
        
        for (int i = height.Length - 2; i >= 0; i--) {
            tallestFromRightSide[i] = height[i + 1] > height[currentTallest] ? i + 1 : currentTallest;
            currentTallest = tallestFromRightSide[i];
        }

        var totalAreaOfWaterTrapped = 0;

        for (int i = 1; i < height.Length - 1; i++) {
            var areaOfWaterTrapped = Math.Max(
                Math.Min(
                    height[tallestFromLeftSide[i]],
                    height[tallestFromRightSide[i]]
                ) - height[i],
                0
            ); // clamp just in case.

            totalAreaOfWaterTrapped += areaOfWaterTrapped;
        }

        return totalAreaOfWaterTrapped;
    }
}
