// https://leetcode.com/problems/distribute-candies/

// Details - Runtime: 316 ms, faster than 97.67% of C# online submissions for Distribute Candies.

public class Solution {
    public int DistributeCandies(int[] candies) {
        int halfAllCandies = candies.Length / 2;
        HashSet<int> uniqueCandies = new HashSet<int>(halfAllCandies);
        // Create set of unique candies
        foreach (int candy in candies) {
            uniqueCandies.Add(candy);
            
            // If same/more unique candies that half the total count
            // then return half the total count
            if (uniqueCandies.Count == halfAllCandies) {
                return halfAllCandies;
            }            
        }                
        
        // Return the number of unique candies
        return uniqueCandies.Count;
    }
}
