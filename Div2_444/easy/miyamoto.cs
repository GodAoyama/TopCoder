using System;
using System.Collections.Generic;



class FourBlocksEasy
{
    public int maxScore(string[] grid)
    {
        int ans = 0;
        int length = grid[0].Length;
        int[,] A = new int[2, length];

        if (length == 1)
        {
            return 2;
        }

        for (int i = 0; i < length; i++)
        {
            if (grid[0][i] == '.')
            {
                A[0, i] = 0;
            }
            else
            {
                A[0, i] = 1;

            }

            if (grid[1][i] == '.')
            {
                A[1, i] = 0;
            }
            else
            {
                A[1, i] = 1;
            }
        }







            for (int i = 0; i < length - 1; i++)
            {
                if ((A[0, i] == 0) && (A[1, i] == 0) && (A[0, i + 1] == 0) && (A[1, i + 1] == 0))
                {
                    A[0, i] = 4;
                    A[1, i] = 4;
                    A[0, i + 1] = 4;
                    A[1, i + 1] = 4;

                }

                else
                {
                    if (A[0, i] == 0)
                    {
                        A[0, i] = 1;
                    }
                    if (A[1, i] == 0)
                    {
                        A[1, i] = 1;
                    }

                    if (i == length - 2)
                    {
                        if (A[0, i + 1] == 0)
                        {
                            A[0, i + 1] = 1;
                        }
                        if (A[1, i + 1] == 0)
                        {
                            A[1, i + 1] = 1;
                        }
                    }
                }
            }


        for (int i = 0; i < length; i++)
        {
            ans = ans + A[0, i] + A[1, i];
        }


            return ans;

    }

}

