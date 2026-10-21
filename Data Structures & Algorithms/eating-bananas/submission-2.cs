
public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int low = 1, high = piles.Max();
        int rate = high;

        while (low <= high) {
            int mid = low + (high - low) / 2;

            long totTime = 0;

            foreach (int pile in piles) {
                totTime += (pile + (long)mid - 1) / mid;
            }

            if (totTime <= h) {
                rate = mid;
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        int ans = rate;
        return ans;
    }
}
