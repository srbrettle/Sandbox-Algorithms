// https://leetcode.com/problems/distribute-candies/submissions/
// Details - Runtime: 74 ms, faster than 88.42% of Java online submissions for Distribute Candies.

class Solution {
    public int distributeCandies(int[] candies) {
        HashSet<Integer> set = new HashSet<Integer>();
        // Create set of unique candies
        for (int candy : candies) {
            set.add(candy);
        }
        
        // If more unique candies that half the total count
        // then return half the total count
        if (set.size() > (candies.length / 2)) {
            return candies.length/2;
        }
        
        // Return the number of unique candies
        return set.size();
    }
}
