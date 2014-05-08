using System;
using System.Collections.Generic;
using System.Linq;

public class ChooseTheBestOne
{
    public int countNumber(int N)
    {
        List<int> list = new List<int>();

        for (int i = 1; i <= N; i++)
            list.Add(i);

        long index = 0;
        for(long turn = 1; turn < N; turn++)
        {
            long threshold = turn * turn * turn;
            index = threshold >= list.Count - index ? (threshold - list.Count + index) % list.Count : index+threshold;
            index = index == 0 ? list.Count - 1 : index - 1;
            list.RemoveAt((int)index);
        }

        return list.ElementAt(0);
    }
}
