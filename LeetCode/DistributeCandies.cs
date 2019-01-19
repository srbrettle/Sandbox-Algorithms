// https://leetcode.com/problems/distribute-candies/

public class Solution {
    public int DistributeCandies(int[] candies) {
        var set = new HashSet<int>();
        // Create set of unique candies
        foreach (int candy in candies) {
            set.Add(candy);
        }
        
        // If more unique candies that half the total count
        // then return half the total count
        if (set.Count > (candies.Count() / 2)) {
            return candies.Count()/2;
        }
        
        // Return the number of unique candies
        return set.Count;
    }
}
