public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder str = new StringBuilder();

        foreach (string s in strs) {
            str.Append(s.Length).Append('#').Append(s);
        }

        return str.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;

        while (i < s.Length) {
            int j = i;

            // Find the '#' separator
            while (s[j] != '#') {
                j++;
            }

            // Read the string length
            int length = int.Parse(s.Substring(i, j - i));

            // Move to the start of the string
            i = j + 1;

            // Read exactly 'length' characters
            j = i + length;
            res.Add(s.Substring(i, length));

            // Move to the next encoded string
            i = j;
        }

        return res;
    }
}