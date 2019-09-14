using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Dynamic;
using System.Linq;
using System.Collections.Generic;
using System;
using LeetCode.Solution;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanToInteger_13 toInteger=new RomanToInteger_13();
            for (int i = 0; i < 4; i++)
            {
                toInteger.Test();
            }
        }
    }
}
