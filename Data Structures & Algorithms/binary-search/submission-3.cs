public class Solution {
    public int Search(int[] nums, int target) {
        int high =nums.Length-1,low=0,mid=0;
        while(low<=high){
            mid = (low+high)/2;
            if(nums[mid]==target){
                return mid;
            }
            else if(nums[mid]>target){
                high = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        return -1;
    }
}
