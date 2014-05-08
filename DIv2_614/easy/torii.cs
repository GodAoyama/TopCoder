using System;

public class MicroStrings
{
    public string makeMicroString(int A, int D)
    {
        string answer = string.Empty;

        int v = A;
        while(true)
        {
            if (v < 0)
                break;
            answer += v.ToString();
            v -= D;
        }

        return answer;
    }
}