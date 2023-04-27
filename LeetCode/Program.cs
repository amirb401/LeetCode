using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            IsAnagram run = new IsAnagram();
            string s = "anagram";
            string t = "nagaram";
            string s2 = "rat";
            string t2 = "car";
            Console.WriteLine(run.isAnagramBool(s2, t2));
        }
    }
}
