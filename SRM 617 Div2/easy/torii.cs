using System;
public class SilverbachConjecture
{
    private bool IsPrime(int value)
    {
        for (int i = 2; i < value; i++)
        {
            if (value % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public int[] solve(int n)
    {
        int y = 0, z = 0;

        for (int i = 4; i <= n / 2; i++)
        {
            y = i;
            z = n - i;

            if (!IsPrime(y) && !IsPrime(z))
                break;               
        }
        return new int[2]{y,z};
    }
}