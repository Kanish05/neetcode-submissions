public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        Dictionary<int,int> dt = new Dictionary<int,int>();
        for(int i =0;i<nums.Length;i++){
            int diff = target - nums[i];
            if(dt.ContainsKey(diff)){
                res[0] = dt[diff];
                res[1]=i;
                return res;
            }
            else{
                dt.Add(nums[i],i);
            }
        }
        return res;
    }
}
