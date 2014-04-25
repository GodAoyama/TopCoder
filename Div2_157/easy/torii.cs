using System;
public class GuessTheNumber
{
    public int noGuesses(int upper, int answer)
    {
        int lower = 1;
        int step = 1;
        while(true)
        {
            int center = (upper + lower )/ 2;

            if (answer == center)
                break;
            if (answer < center)
                upper = center - 1;
            if (center < answer)
                lower = center + 1;

            step++;
        }

        return step;
    }
}