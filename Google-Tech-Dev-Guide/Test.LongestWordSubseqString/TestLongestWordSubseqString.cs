using System;
using Xunit;
using LongestWordSubseqString;
using System.Collections.Generic;

namespace Test.LongestWordSubseqString
{
    public class TestLongestWordSubseqString
    {
        [Fact]
        public void Test_FindLongestWordSubseqString()
        {
            string str = "abppplee";
            ICollection<string> words = new List<string>() { "able", "ale", "apple", "bale", "kangaroo" };

            string longestSubseqWord = str.FindLongestWordSubseqString(words);

            Assert.Equal("apple", longestSubseqWord);
        }
    }
}
