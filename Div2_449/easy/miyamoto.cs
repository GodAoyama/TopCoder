using System;
using System.Linq;

class MountainRoad
{
    public double findDistance(int[] start, int[] finish)
    {
        int min = (start.Min() < finish.Min() ? start.Min() : finish.Min());
        int max = (start.Max() > finish.Max() ? start.Max() : finish.Max());
        return Math.Sqrt(2) * (max - min);


    }
}