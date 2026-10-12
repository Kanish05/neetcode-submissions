public class Solution {
    public int FindMin(int[] nums) {
        int low =0, high = nums.Length -1, mid =0, ans = int.MaxValue;

        while(low<=high){
            mid = (low +high)/2;

            if(nums[low] <= nums[mid]){
                ans = Math.Min(ans,nums[low]);
                low = mid+1;
            }
            else{
                high = mid -1;
                ans= Math.Min(ans,nums[mid]);
            }
        }
        return ans;
    }
}
