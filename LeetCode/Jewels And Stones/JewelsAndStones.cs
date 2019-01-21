// https://leetcode.com/problems/jewels-and-stones/

public class Solution {
    public int NumJewelsInStones(string J, string S) {
        return S.ToCharArray().Count(x => J.ToCharArray().Contains(x));
    }
}
