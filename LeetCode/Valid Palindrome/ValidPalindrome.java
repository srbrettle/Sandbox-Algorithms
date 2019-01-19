// https://leetcode.com/problems/valid-palindrome/submissions/
// Details - Runtime: 6 ms, faster than 95.30% of Java online submissions for Valid Palindrome.

class Solution {
    public boolean isPalindrome(String s) {
        char[] chars = s.toCharArray();
        int left = 0;
        int right = s.length() - 1;

        while (left < right)
        {
            while (!Character.isLetterOrDigit(chars[left]) && (left < right))
            {
                ++left;
            }
            while (!Character.isLetterOrDigit(chars[right]) && (right > left))
            {
                --right;
            }
            if (Character.toLowerCase(chars[left]) != Character.toLowerCase(chars[right]))
            {
                return false;
            }
            ++left;
            --right;
        }
        return true;
    }
}
