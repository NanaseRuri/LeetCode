using System;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode.Solution
{
    public class LetterCombinationsOfAPhoneNumber_017
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }

            Dictionary<char, List<string>> dictionary = new Dictionary<char, List<string>>(){
                {'2',new List<string>{"a","b","c"}},
                {'3',new List<string>{"d","e","f"}},
                {'4',new List<string>{"g","h","i"}},
                {'5',new List<string>{"j","k","l"}},
                {'6',new List<string>{"m","n","o"}},
                {'7',new List<string>{"p","q","r","s"}},
                {'8',new List<string>{"t","u","v"}},
                {'9',new List<string>{"w","x","y","z"}}
            };

            var temp = from e in dictionary[digits[0]]
                       select e.ToString();
            for (int i = 1; i < digits.Length; i++)
            {
                int j=i;
                temp = from t1 in temp
                       from t2 in dictionary[digits[j]]
                       select t1 + t2;
            }

            return temp.ToList();
        }
        public void Test()
        {
            IList<string> result = LetterCombinations("234");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}