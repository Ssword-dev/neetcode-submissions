public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        return strs.GroupBy(s => HashFrequencyTableArray(FrequencyTableArray(s))).Select(g => g.ToList()).ToList();
    }

    public int[] FrequencyTableArray(string s) {
        var frequencyTable = new int[26];
        
        foreach (var c in s) {
            frequencyTable[c - 'a']++;
        }

        return frequencyTable;
    }

    public string HashFrequencyTableArray(int[] frequencyTableArray) {
        return string.Join(',', frequencyTableArray);
    }
}
