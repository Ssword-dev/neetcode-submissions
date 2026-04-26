public class Solution {
    // so what we need is to maximize the height * width
    // of the solution, we may do this by doing a 2 pointer approach
    // where we have one pointer from the start and one from the end,
    // initially, we have the width maximized, first, record
    // the current area, then check which is
    // a lower height, then move that pointer, this makes the potential
    // area much larger for the next iteration. repeat until i
    // and j is the same or they are adjacent to each other.
    // by the time we have done all this, we got the max area.
    // although we should probably handle the both are equal edge case
    // but that is easy to do.

    public int MaxArea(int[] heights) {
        var i = 0;
        var j = heights.Length - 1;
        var maxArea = 0;

        while (i < j) {
            var height = Math.Min(heights[i], heights[j]);
            var width = j - i;
            maxArea = Math.Max(maxArea, width * height);
            
            if (heights[i] < heights[j]) {
                i++;
            }

            else {
                j--;
            }
        }

        return maxArea;
    }
}
