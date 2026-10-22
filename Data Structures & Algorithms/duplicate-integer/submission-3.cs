public class Solution {
    public bool hasDuplicate(int[] nums) {
         Dictionary<int, int> numDicts = new();
        foreach (int num in nums)
        {
            if (numDicts.ContainsKey(num))
            {
                return true;
            }
            else
            {
                numDicts[num] = 1;
            }
        }
        return false;
    }
}