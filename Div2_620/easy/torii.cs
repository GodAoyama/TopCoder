using System;
using System.Collections.Generic;
using System.Linq;

public class CandidatesSelectionEasy
{
    public int[] sort(string[] score, int x)
    {
        List<int> list = new List<int>();

        for (char i = 'A'; i <= 'Z'; i++)
        {
            for (int j = 0; j < score.Length; j++)
            {
                if (score[j][x] == i)
                    list.Add(j);
            }
        }

        return list.ToArray();
    }
}