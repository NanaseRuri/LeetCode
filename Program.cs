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
            RegularExpressionMatching_010 matching = new RegularExpressionMatching_010();
            for (int i = 0; i < 4; i++)
            {
                matching.Test();
            }
        }
    }
}
