using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

class YahtzeeScore
{
    int[] toss;

    public int maxPoints(int[] toss)
    {
        int max = 0;
        int tmp = 0;
        Array.Sort(toss);
        for (int i = 0; i < toss.Length; i++)
        {
            if (i == 0)
            {
                tmp = toss[i];
            }
            else
            {
                if (toss[i - 1] == toss[i])
                {
                    tmp += toss[i];
                }
                else
                {
                    if (max < tmp)
                    {
                        max = tmp;
                        tmp = toss[i];

                    }
                    else
                    {
                        tmp = toss[i];
                    }


                }
            }

            System.Console.WriteLine(toss[i]);
        }

        if (tmp > max)
        {
            max = tmp;
        }


        return max;
    }


}


