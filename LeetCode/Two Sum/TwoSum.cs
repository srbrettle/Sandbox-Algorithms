// https://leetcode.com/problems/two-sum
// Details - Runtime: 300 ms, faster than 74.13% of C# online submissions for Two Sum.

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int needed = target - nums[i];
            if (dictionary.ContainsKey(needed)) {
                return new int[] { dictionary[needed], i };
            }
            dictionary[nums[i]] = i;
        }
    return null;
    }
}
