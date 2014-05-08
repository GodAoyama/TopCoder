using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ChooseTheBestOne
{
    public static int countNumber(int N)
    {
        int point = 0;
        List<int> circle = new List<int>();
        circle.AddRange(Enumerable.Range(1, N));

        for (long turn = 1; turn <= N - 1; turn++)
        {
            long count = (turn * turn * turn) % circle.Count;
            if (count == 0)
            {
                count = circle.Count;
            }
            for (int i = 0; i < count - 1; i++)
            {
                point = (point + 1) % circle.Count;
            }
            circle.RemoveAt(point);
            if (point == circle.Count)
            {
                point = 0;
            }

        }
        return circle[0];
    }
}