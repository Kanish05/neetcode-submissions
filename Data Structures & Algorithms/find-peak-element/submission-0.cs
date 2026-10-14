public class Solution {
    public int FindPeakElement(int[] nums) {
        if(nums.Length == 1){
            return 0;
        }

        if(nums[0] > nums[1]){
            return 0;
        }

        if(nums[nums.Length - 1] > nums[nums.Length - 2]){
            return nums.Length - 1;
        }

        int low = 1, high = nums.Length - 2;

        while(low <= high){
            int mid = low + (high - low) / 2;

            if(nums[mid] > nums[mid - 1] &&
               nums[mid] > nums[mid + 1]){
                return mid;
            }

            if(nums[mid] > nums[mid + 1]){
                high = mid - 1;
            }
            else{
                low = mid + 1;
            }
        }

        return -1;
    }
}