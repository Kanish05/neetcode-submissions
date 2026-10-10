public class Solution {
    public int Search(int[] nums, int target) {
        for(int i=0;i<=nums.Length-1;i++){
            if(nums[i]==target){
                return i;
            }
        }
        return -1;
    }
}
