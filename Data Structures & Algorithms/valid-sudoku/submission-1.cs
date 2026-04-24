public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var boxes = new int[3, 3];
        var rows = new int[9];
        var cols = new int[9];

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                var tile = board[r][c];

                // a '.' tile is an empty tile.
                if (tile == '.') continue;

                var tileValue = tile - '0';
                var row = rows[r];
                var col = cols[c];
                var boxRow = r / 3;
                var boxColumn = c / 3;

                var box = boxes[boxRow, boxColumn];
                var mask = (1 << (tileValue - 1));

                if ((row & mask) == mask || (col & mask) == mask || (box & mask) == mask) {
                    return false;
                }

                else {
                    rows[r] = row | mask;
                    cols[c] = col | mask;
                    boxes[boxRow, boxColumn] = box | mask;
                }
            }
        }

        return true;
    }
}
