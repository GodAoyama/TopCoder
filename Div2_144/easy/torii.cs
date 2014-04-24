using System;

public class Time
{
    public string whatTime(int sec)
    {
        int h = sec/3600;
        int m = (sec%3600)/60;
        int s = ((sec%3600)%60);
        
        return h.ToString() + ":" + m.ToString() + ":" + s.ToString();
    }
}