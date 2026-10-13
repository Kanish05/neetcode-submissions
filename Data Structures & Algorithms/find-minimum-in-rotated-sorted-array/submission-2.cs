public class Solution {
    public int FindMin(int[] nums) {
        int low =0, high = nums.Length -1, mid =0, answer = int.MaxValue;

        while(low<=high){
            mid = (low +high)/2;

            if(nums[low] <= nums[mid]){
                answer = Math.Min(answer,nums[low]);
                low = mid+1;
            }
            else{
                high = mid -1;
                answer= Math.Min(answer,nums[mid]);
            }
        }
        return answer;
    }
}
