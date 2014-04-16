using System;

public class MountainRoad
{
    public double findDistance(int[] start, int[] finish)
    {
	double minStart = double.MaxValue;
	double maxFinish = double.MinValue;
	foreach(int v in start)
	{
            minStart = v < minStart ? v : minStart;
        }
	foreach(int v in finish)
	{
            maxFinish = maxFinish < v ? v : maxFinish;
        }
            return (maxFinish-minStart)*Math.Sqrt(2);
    }
}