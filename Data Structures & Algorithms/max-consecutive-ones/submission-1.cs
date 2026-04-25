public class Solution {
    // when we encounter a 1, we need to increase the current
    // count of consecutive ones.
    // when we encounter a 0, we stop counting ones, and find if
    // it is the new highest count of ones, if it is, we update
    // our answer, else, we do not.
    // at the end of the loop, we must flush out any count of 1s
    // that have not been considered.
    // we can do a foreach loop here.
    public int FindMaxConsecutiveOnes(int[] nums) {
        var maxConsecutiveOnes = 0;
        var numberOfCurrentConsecutiveOnes = 0;

        foreach (var num in nums) {
            if (num == 1) {
                numberOfCurrentConsecutiveOnes++;
            }

            else {
                maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, numberOfCurrentConsecutiveOnes);
                numberOfCurrentConsecutiveOnes = 0; // reset for next sequence.
            }
        }

        // flush remaining.
        maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, numberOfCurrentConsecutiveOnes);
        
        return maxConsecutiveOnes;
    }
}