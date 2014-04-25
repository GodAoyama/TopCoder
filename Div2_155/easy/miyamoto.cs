using System;
using System.Collections.Generic;

class Quipu
{
    public int readKnots(string knots)
    {
        int ans = 0;
        int X_count = 0;
        int zero_count = 0;
        string str = "";

        for (int i = 1; i < knots.Length; i++)
        {
            if (knots[i] == knots[i - 1])
            {
                if (knots[i] == 'X')
                {
                    X_count++;
                }
                else
                {
                    zero_count++;
                }
            }
            else
            {
                if (knots[i - 1] == 'X')
                {
                    X_count++;
                    str = str + X_count;
                    //System.Console.WriteLine(str);
                }
                else
                {
                    zero_count++;
                    for (int j = 0; j < zero_count - 1; j++)
                    {
                        str = str + 0;
                        System.Console.WriteLine("zero_count = " + zero_count);
                    }
                }

                if (i == knots.Length - 1)
                {
                    for (int j = 0; j < zero_count; j++)
                    {
                        str = str + 0;
                        //System.Console.WriteLine("zero_count = " + zero_count);
                    }
                }

                X_count = 0;
                zero_count = 0;
            }


        }

        for (int j = 0; j < zero_count; j++)
        {
            str = str + 0;
            //System.Console.WriteLine("zero_count = " + zero_count);
        }



            ans = int.Parse(str);

        return ans;
    }

}

