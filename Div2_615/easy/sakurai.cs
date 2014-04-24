using System;
using System.Linq;

public class AmebaDiv2
{
    public static int simulate(int[] X, int A)
    {
        for (int i = 0; i < X.Length; i++)
        {
            if (X[i] == A)
            {
                A *= 2;
            }
        }
        return A;

    }
}