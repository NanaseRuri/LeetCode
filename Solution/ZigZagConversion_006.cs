using System.Linq;
using System.Collections.Generic;
using System.Text;
using System;
namespace LeetCode.Solution
{
    public class ZigZagConversion_006
    {
        public string Convert(string s, int numRows)
        {
            StringBuilder[] rows=new StringBuilder[numRows];
            for(int i=0;i<rows.Length;i++){
                rows[i]=new StringBuilder();
            }

            if (numRows == 1)
            {
                return s;
            }
            
            else
            {
                int interval=2*numRows-2;
                for (int i = 0; i < s.Length; i++)
                {
                    int rowAccording = i % interval;
                    int rowNumber = Math.Min(rowAccording, interval - rowAccording);
                    rows[rowNumber].Append(s[i]);
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var row in rows)
            {
                stringBuilder.Append(row);
            }
            return stringBuilder.ToString();
        }

        public void Test()
        {
            Console.WriteLine("请输入字符串");
            string s = Console.ReadLine();
            Console.WriteLine("请输入行数");
            string rowNumber = Console.ReadLine();

            int rowCount = int.Parse(rowNumber);

            Console.WriteLine(Convert(s, rowCount));
        }
    }
}