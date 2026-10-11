public class Solution {
    public int Search(int[] arr, int key) {
        int low =0, high = arr.Length -1 , mid =0;

        while(low <= high){
            mid = (low + high)/2;
            if(arr[mid] == key){
                return mid;
            }

            //left sorted
            if(arr[low] <= arr[mid]){
                if(key >= arr[low] && key < arr[mid]){
                    high = mid -1;
                }
                else{
                    low = mid + 1;
                }
            }
            //right sorted
            else{
                if(key >= arr[mid] && key <= arr[high] ){
                    low = mid+1;
                }
                else{
                    high = mid-1;
                }
                
            }
        }
        return -1;
    }
}
