public class Solution {
    public bool hasDuplicate(int[] nums) {
         Dictionary<int, int> numDict = new();
        foreach (int num in nums)
        {
            if (numDict.ContainsKey(num))
            {
                return true;
            }
            else
            {
                numDict[num] = 1;
            }
        }
        return false;
    }
}