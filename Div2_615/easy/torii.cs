using System;
public class AmebaDiv2
{
    public int simulate(int[] X, int A)
    {
        int size = A;
        foreach(int v in X){
            if (v == size)
                size += size;
        }
        return size;
    }
}