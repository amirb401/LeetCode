using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Completed
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            //Formalize string into alpha-numerical characters only.
            string cleanString = "";
            for (int indx = 0; indx < s.Length; indx++)
            {
                if (char.IsLetterOrDigit(s[indx]))
                {
                    cleanString += s[indx];
                }
            }
            cleanString = cleanString.ToLower();

            //Verify if new string is palindrome or not
            int i = 0;
            int j = cleanString.Length - 1;
            while (i < j && i < cleanString.Length)
            {
                char start = cleanString[i];
                char end = cleanString[j];
                //string debug = $"i = {i} , j = {j}, start = {start} , end = {end}";
                //Console.WriteLine(debug);

                if (start == end)
                {
                    i++;
                    j--;
                }
                else
                    return false;
            }
            return true;
        }
    }

    //Tests:
    //string test = "race a car";
    //string test2 = "A man, a plan, a canal: Panama";

    //ValidPalindrome palindrome = new ValidPalindrome();
    //Console.WriteLine(palindrome.IsPalindrome(test));

}
