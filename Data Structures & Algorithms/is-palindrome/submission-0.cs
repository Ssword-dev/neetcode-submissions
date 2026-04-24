public class Solution {
    public bool IsPalindrome(string s) {
        var i = 0;
        var j = s.Length - 1;

        while (i < j) {
            var charAtI = char.ToLower(s[i]);
            var charAtJ = char.ToLower(s[j]);
            var charAtIIsAlphaNumeric = char.IsLetterOrDigit(charAtI);
            var charAtJIsAlphaNumeric = char.IsLetterOrDigit(charAtJ);
            var shouldSkip = false;

            if (!charAtIIsAlphaNumeric) {
                i++;
                shouldSkip = true;
            }

            if (!charAtJIsAlphaNumeric) {
                j--;
                shouldSkip = true;
            }

            if (shouldSkip) {
                continue;
            }

            if (charAtI != charAtJ) {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}
