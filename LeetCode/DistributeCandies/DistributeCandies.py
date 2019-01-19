# https://leetcode.com/problems/distribute-candies
# Details - Runtime: 140 ms, faster than 82.35% of Python online submissions for Distribute Candies.

class Solution:
    def distributeCandies(self, candies):        
        halfAllCandies = int(len(candies)/2)
        uniqueCandies = len(set(candies))
            
        return min(halfAllCandies, uniqueCandies)                                    
