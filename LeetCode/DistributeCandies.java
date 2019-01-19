// https://leetcode.com/problems/distribute-candies/submissions/
// Details - Runtime: 53 ms, faster than 98.00% of Java online submissions for Distribute Candies.

class Solution {
    public int distributeCandies(int[] candies) {
        int halfAllCandies = candies.length/2;
        HashSet<Integer> uniqueCandies = new HashSet<Integer>(halfAllCandies);
        
        // Create set of unique candies
        for (int candy : candies) {            
            if (uniqueCandies.size() == halfAllCandies) {
                // If more unique candies that half the total count
                // then return half the total count                
                return halfAllCandies;               
            }
            uniqueCandies.add(candy);
        }    
        
        // Return the number of unique candies
        return uniqueCandies.size();
    }
}
