using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class FixedPointTheorem
{
    public static double cycleRange(double R)
    {
        double high = 0, low = 1;
        double x = 0.25;
        for (int i = 0; i < 200000; i++)
        {
            x = fx(R, x);
        }
        for (int i = 0; i < 1000; i++)
        {
            x = fx(R, x);
            if (x > high)
            {
                high = x;
            }
            if (x < low)
            {
                low = x;
            }
        }
        return high - low;
    }

    public static double fx(double r, double x)
    {
        return r * x * (1 - x);
    }

}