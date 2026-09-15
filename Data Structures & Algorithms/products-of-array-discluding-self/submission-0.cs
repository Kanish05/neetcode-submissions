public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
         int[] res = new int[nums.Length];

         int prefix = 1;

         for(int i=0;i<nums.Length;i++){
            res[i] = prefix;
            prefix = prefix * nums[i];
         }

         int postfix =1;
         for(int i=nums.Length-1;i>=0;i--){
            res[i] = postfix * res[i];
            postfix = postfix*nums[i]; 
         }

         return res;
    }
}
