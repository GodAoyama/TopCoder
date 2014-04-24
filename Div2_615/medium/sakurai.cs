using System;
using System.Linq;

public class LongLongTripDiv2
{
    public static string isAble(long D, int T, int B)
    {
        long TL = (long)T;
        long BL = (long)B;
        for (int i = 0; i <= T + 1000000; i += 1000000)
        {
            if (BL * i + TL - i >= D)
            {

                for (int j = i - 1000000; j <= i; j++)
                {
                    if (i == 0)
                    {
                        if (j < 0)
                        {
                            continue;
                        }
                    }
                    if (BL * j + TL - j == D && j <= T)
                    {
                        return "Possible";
                    }
                }
                break;
            }

        }
        return "Impossible";

    }
}