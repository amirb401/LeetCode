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
            MaxProfit run = new MaxProfit();
            Console.WriteLine(run.MaxProfitFunc(new int[] { 7, 1, 5, 3, 6, 4 }));
        }
    }
}
