public class Solution {
    public bool CheckInclusion(string s1, string s2) {
         if (s1.Length > s2.Length)
            return false;

        Dictionary<char, int> target = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        // Frequency of characters in s1
        foreach (char c in s1)
        {
            if (!target.ContainsKey(c))
                target[c] = 0;

            target[c]++;
        }

        int left = 0;

        for (int right = 0; right < s2.Length; right++)
        {
            char current = s2[right];

            // Add current character to window
            if (!window.ContainsKey(current))
                window[current] = 0;

            window[current]++;

            // Keep window size equal to s1.Length
            if (right - left + 1 > s1.Length)
            {
                char remove = s2[left];

                window[remove]--;
                left++;

                if (window[remove] == 0)
                    window.Remove(remove);
            }

            // Compare frequencies
            if (right - left + 1 == s1.Length &&
                AreSame(target, window))
            {
                return true;
            }
        }

        return false;
    }

    private bool AreSame(
        Dictionary<char, int> target,
        Dictionary<char, int> window)
    {
        if (target.Count != window.Count)
            return false;

        foreach (var pair in target)
        {
            if (!window.ContainsKey(pair.Key) ||
                window[pair.Key] != pair.Value)
            {
                return false;
            }
        }

        return true;
    }
}
