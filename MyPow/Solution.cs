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
            if ((n & 1) == 0)
            {
                return MyPow(x * x, n / 2);
            }
            return x * MyPow(x * x, n / 2);
        }
    }
}