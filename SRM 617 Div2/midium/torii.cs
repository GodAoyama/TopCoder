
//testはる羽化するけどsystemtestを通過しない
//誰か教えてー

using System;
public class SlimeXSlimonadeTycoon
{
    public int sell(int[] morning, int[] customers, int stale_limit)
    {
        int sold = 0;
        for (int i = morning.Length-1; i >= 0; i--)
        {
            for(int j = 0; j < stale_limit; j++)
            {
                if (i - j < 0)
                    continue;
                if(morning[i-j]-customers[i] >= 0)
                {
                    morning[i-j] -= customers[i];
                    sold += customers[i];
                }
                else
                {
                    customers[i] -= morning[i-j];
                    sold += morning[i-j];
                    morning[i-j] = 0;
                }
            }
        }

        return sold;
    }
}