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
            IntegerToRoman_12 roman_12=new IntegerToRoman_12();
            for (int i = 0; i < 4; i++)
            {
                roman_12.Test();
            }
        }
    }
}
