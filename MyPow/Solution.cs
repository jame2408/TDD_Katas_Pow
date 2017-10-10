namespace MyPow
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n < 0)
            {
                x = 1 / x;
                n *= -1;
            }
            var answer = 1d;
            for (int i = 0; i < n; i++)
            {
                answer *= x;
            }
            return answer;
        }
    }
}