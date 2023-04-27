using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Completed
{
    /*
     * Given two strings s and t, return true if t is an anagram of s, and false otherwise.
     * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
     * typically using all the original letters exactly once.
*/
    public class IsAnagram
    {
        public bool isAnagramBool(string s, string t)
        {
            Dictionary<char, int> charDic = new Dictionary<char, int>();

            // Iterate through 's' and add count of each letter
            foreach (char letter in s)
            {
                if (charDic.ContainsKey(letter)) // If letter already in Dict then increase counter
                    charDic[letter] += 1;
                else
                    charDic.Add(letter, 1); // Else, first occurence, add the letter to Dict
            }

            //iterate through 't' and count each letter, decrease from Dictionary every occurence.
            foreach (char letter in t)
            {
                if (!charDic.ContainsKey(letter)) //Letter doesn't exist in first string, return false.
                    return false;
                else
                {
                    charDic[letter] -= 1;
                    if (charDic[letter] < 0) // If 't' has more occurences for letter then in 's', return false.
                        return false;
                }
            }


            // foreach loop on all dic items. if any has value != 0, return false.
            foreach (var (letter, value) in charDic)
            {
                if (charDic[letter] != 0)
                    return false;
            }
            return true;
        }
    }
}