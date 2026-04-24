public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach (string s in strs) {
            sb.Append(s.Length).Append(";").Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var chunks = new List<string>();
        int i = 0;
        
        while (i < s.Length) {
            int beginningOfLength = i;
            
            while (s[i] != ';') {
                i++;
            }

            int lengthOfLength = i - beginningOfLength;
            i++; // skip semicolon

            var chunkLength = int.Parse(s.Substring(beginningOfLength, lengthOfLength));
            var chunk = s.Substring(i, chunkLength);
            chunks.Add(chunk);
            i = i + chunkLength;
        }

        return chunks;
   }
}