using System;
using System.Linq;

class LongLongTripDiv2
{
    public string isAble(long D, int T, int B)
    {
        bool ans = false;
        long distance;
        int Init = 0;
        int end = T;
        int interval = 10000000;

        System.Console.WriteLine("11111");
        while (true)
        {
            if ((long)(Init + interval) * B + (long)(T - Init - interval) < D)
            {
                Init = Init + interval;
            }
            else
            {
                break;
            }
        }
        System.Console.WriteLine("22222");

        for (int i = Init; i <= Init + interval; i++)
        {
            distance = (long)i * B + (long)(T - i);
            if (distance == D)
            {
                ans = true;
                break;
            }

            if (distance > D)
            {
                ans = false;
                break;
            }

        }

       

        if (ans == true)
        {
            return "Possible";
        }
        else
        {
            return "Impossible";
        }

    }
}