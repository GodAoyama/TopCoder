using System;
public class LongLongTripDiv2
{
    public string isAble(long D, int T, int B)
    {
        long bigStep = ((long)D - (long)T) / ((long)B - 1);
        long smallStep = (long)T - bigStep;

        if (bigStep < 0 || smallStep < 0)
            return "Impossible";
        else if (bigStep * (long)B + smallStep == D)
            return "Possible";
        else
            return "Impossible";
    }
}