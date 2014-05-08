
using System;
using System.Collections.Generic;
using System.Linq;
public class TorusSailingEasy
{
    public double expectedTime(int N, int M, int goalX, int goalY)
    {
        const int REPEAT_N = 100000;
        double[,,] prob = new double[REPEAT_N, N, M];
        prob[0,0,0] = 1;

        for (int i = 0; i < REPEAT_N - 1; i++)
        {
            for (int n = 0; n < N; n++)
            {
                for (int m = 0; m < M; m++)
                {
                    if(n == goalX && m ==goalY)
                        continue;
                    prob[i + 1, (n + 1 + N) % N, (m + 1 + M) % M] += prob[i, n, m] * 0.5;
                    prob[i + 1, (n - 1 + N) % N, (m - 1 + M) % M] += prob[i, n, m] * 0.5;
                }
            }
        }

        double ansProb = 0;
        for (int i = 0; i < REPEAT_N; i++)
            ansProb += i*prob[i, goalX, goalY];

        return ansProb < 1e-9 ? -1 : ansProb;
    }
}