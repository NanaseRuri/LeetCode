using System.Dynamic;
using System.Linq;
using System.Collections.Generic;
using System;
using LeetCode.Solution;

namespace LeetCode
{
    class DynamicTest:DynamicObject{
        
    }
    class Program
    {

        static void Main(string[] args)
        {
            ZigZagConversion_006 test=new ZigZagConversion_006();
            test.Test();
        }
    }
}
