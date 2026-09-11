public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char ch in s)
        {
            if (freq.ContainsKey(ch))
                freq[ch]++;
            else
                freq[ch] = 1;
        }

        foreach (char ch in t)
        {
            if (!freq.ContainsKey(ch))
                return false;

            freq[ch]--;
        }

        foreach (var pair in freq)
        {
            if (pair.Value != 0)
                return false;
        }

        return true;
    }
}