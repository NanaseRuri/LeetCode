namespace LeetCode.Solution
{
    public class PalindromeNumber_009
    {
        public bool IsPalindrome(int x)
        {
            int origin = x;
            int result = 0;
            if (x < 0)
            {
                return false;
            }
            while (x != 0)
            {
                int temp = x % 10;
                result = 10 * result + temp;
                x /= 10;
            }
            return result == origin;
        }
    }
}