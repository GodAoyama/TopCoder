public int EulerPhi(int n)
{
    int result = n;
    if (n == 0)
        return 0;

    for(int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
            result -= result / i;
        while (n % i == 0)
            n /= i;
    }

    if (n > 1)
        result -= result / n;

    return result;
}