using System;


class SoccerLeagues
{
    public int[] points(string[] matches)
    {
        int[] ans = new int[matches.Length];

        //home
        for (int i = 0; i < matches.Length; i++)
        {
            for (int j = 0; j < matches[i].Length; j++)
            {
                if (matches[i][j] == 'W')
                {
                    ans[i] += 3;
                }
                else if (matches[i][j] == 'D')
                {
                    ans[i] += 1;
                }
            }
        }

        //away
        for (int j = 0; j < matches.Length; j++)
        {
            for (int i = 0; i < matches.Length; i++)
            {
                if (matches[i][j] == 'L')
                {
                    ans[j] += 3;
                }
                else if (matches[i][j] == 'D')
                {
                    ans[j] += 1;
                } 
            }
        }

            return ans;
    }
}
