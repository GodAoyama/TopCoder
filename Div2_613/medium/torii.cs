using System;
using System.Collections.Generic;
using System.Linq;

public class TaroFriends
{
    public int getNumber(int[] coordinates, int X)
    {
        Array.Sort(coordinates);

        int[] moved = new int[coordinates.Length];
        int distance = coordinates[coordinates.Length-1] - coordinates[0];

        for (int i = 0; i < coordinates.Length; i++)
        {
            for (int k = 0; k < coordinates.Length; k++)
                moved[k] = k <= i ? coordinates[k]+X : coordinates[k]-X;

            distance = Math.Min(distance, moved.Max() - moved.Min());
        }

        return distance;
    }
}