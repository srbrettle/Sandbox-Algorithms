using System;
using System.Collections.Generic;

namespace LongestWordSubseqString
{
    /// <summary>
    /// Challenge from Google Tech Dev Guide
    /// https://techdevguide.withgoogle.com/paths/foundational/find-longest-word-in-dictionary-that-subsequence-of-given-string#code-challenge
    /// </summary>
    public static class LongestWordSubseqString
    {
        /// <summary>
        /// Looks for the longest word in a given dictionary that can be found in a strings sequence without reordering
        /// </summary>
        /// <param name="mainString"></param>
        /// <param name="setOfWords"></param>
        /// <returns></returns>
        public static string FindLongestWordSubseqString(this string mainString, IEnumerable<string> setOfWords)
        {
            string longestWordThatsSubseq = "";

            foreach (string word in setOfWords)
            {
                if ((word.Length > longestWordThatsSubseq.Length) && (mainString.TryFindWordInStringSequence(word)))
                {
                    longestWordThatsSubseq = word;
                }
            }

            return longestWordThatsSubseq;
        }

        /// <summary>
        /// Tries to find a given word withing a strings sequence
        /// </summary>
        /// <param name="mainString"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        private static bool TryFindWordInStringSequence(this string mainString, string word)
        {
            int startPosition = 0;
            foreach (char character in word)
            {
                bool foundCharacter = mainString.TryFindCharPositionInRemainderOfWord(character, startPosition, out int foundPosition);
                if (!foundCharacter)
                {
                    return false;
                }

                // Found character
                startPosition = foundPosition + 1;
            }

            return true;
        }
        
        /// <summary>
        /// Tries to find the given characters position in the remaining portion of the word
        /// </summary>
        /// <param name="word"></param>
        /// <param name="character"></param>
        /// <param name="startPosition"></param>
        /// <param name="foundPosition"></param>
        /// <returns></returns>
        private static bool TryFindCharPositionInRemainderOfWord(this string word, char character, int startPosition, out int foundPosition)
        {
            for (int i = startPosition; i < word.Length; i++)
            {
                if (word[i] == character)
                {
                    foundPosition = i;
                    return true;
                }
            }
            foundPosition = -1;
            return false;
        }
    }
}
