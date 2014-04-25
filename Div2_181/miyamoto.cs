using System;

class KiloMan
{
    public int hitsTaken(int[] pattern, string jumps)
    {
        int ans = 0;
        for (int i = 0; i < jumps.Length; i++)
        {
            if (jumps[i] == 'S')
            {
                if (pattern[i] < 3)
                {
                    ans++;
                }
            }
            else
            {
                if (pattern[i] > 2)
                {
                    ans++;
                }
            }
        }

        return ans;
    }

}