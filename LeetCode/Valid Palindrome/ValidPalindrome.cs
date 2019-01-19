// https://leetcode.com/problems/valid-palindrome/
// Details - Runtime: 92 ms, faster than 99.42% of C# online submissions for Valid Palindrome.

public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (!char.IsLetterOrDigit(s[left]) && (left < right))
            {
                ++left;
            }
            while (!char.IsLetterOrDigit(s[right]) && (right > left))
            {
                --right;
            }
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            ++left;
            --right;
        }
        return true;
    }
}
