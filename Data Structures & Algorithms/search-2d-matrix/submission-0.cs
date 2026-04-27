public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l = 0;
        int columnCount = matrix[0].Length;
        int r = (matrix.Length * columnCount) - 1;

        while (l <= r) {
            var m = (l+r) / 2; // naturally floors
            var row = m / columnCount;
            var col = m % columnCount;

            if (matrix[row][col] == target) {
                return true;
            }

            else if (matrix[row][col] < target) {
                l = m + 1;
            }

            else {
                r = m - 1;
            }
        }

        return false;
    }
}
