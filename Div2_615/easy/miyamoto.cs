using System;
using System.Linq;

class AmebaDiv2
{
    public int simulate(int[] X, int A)
    {
        int ans = A;
        for (int i = 0; i < X.Length; i++)
        {
            if (ans == X[i])
            {
                ans *= 2;
            }
        }

        return ans;

    }
}