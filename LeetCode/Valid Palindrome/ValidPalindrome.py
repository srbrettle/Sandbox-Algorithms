# https://leetcode.com/problems/valid-palindrome
# Details - Runtime: 80 ms, faster than 96.90% of Python3 online submissions for Valid Palindrome.

class Solution:
    def isPalindrome(self, s):
        import re
        s = re.sub(r"[^a-z0-9]","",s.lower())
        
        return str(s) == str(s)[::-1]
