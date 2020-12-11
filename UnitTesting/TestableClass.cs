using System;

namespace UnitTesting
{
    public class TestableClass
    {
        public bool IsPrime(int candidate)
        {
            int n, i, m = 0, flag = 0; 
            m = candidate / 2;
            for (i = 2; i <= m; i++)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }
            if (flag == 0)
                return true;
            else
                return false;
        }
    }
}
