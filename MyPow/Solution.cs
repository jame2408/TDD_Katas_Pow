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
            return x * x;
        }
    }
}