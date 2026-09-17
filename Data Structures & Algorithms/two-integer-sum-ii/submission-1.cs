public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];
        int start = 0;
        int end = numbers.Length -1;
        while(start < end){
            int check = numbers[start] + numbers[end];
            if(check > target){
                end--;
            }
            if(check < target){
                start++;
            }

            if(check == target){
                res[0] = start +1;
                res[1] = end+1;
                break;
            }
        }

        return res;
    }
}
