public class OddDivisors
{
    bool odd(int n)
    {
        return n%2 == 1;
    }
    public long findSum(int N)
    {		
	long sum = 0;
	for(int k = 1; k <= N; k++)
	{
            if(odd(k))	sum += k;
            else
            {
                int value = k/2;
                while(true)
                {
                    if(odd(value))
                    {
                        sum += value;
                        break;
                    }
                    value /= 2;
                }
            }
        }
    
        return sum;
    }
}