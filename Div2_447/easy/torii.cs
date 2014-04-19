using System;

public class ImportantTasks
{
    public int maximalCost(int[] complexity, int[] computers)
    {
        Array.Sort(complexity);
        Array.Sort(computers);
    
        int count = 0;
        for(int i = complexity.Length-1; i>= 0 ; i--)
        {
            for(int j = computers.Length-1; j>= 0; j--)
            {
                if (complexity[i] <= computers[j])
                {
                    count++;
                    Array.Clear(complexity,i,1);
                    Array.Clear(computers,j,1);
                    break;
                }
            }
        }
    
        return count;
    }
}