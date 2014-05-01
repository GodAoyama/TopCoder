using System;
using System.Collections.Generic;
using System.Linq;

public class EmoticonsDiv2
{
    public int printSmiles(int smiles)
    {
        int clipBorad = 0;
        int currentSmile = 1;
        int sec = 0;
        bool copied = false;

        for(int i = 0; i < smiles; i++)
        {
            if (currentSmile >= smiles)
                break;
            if (!copied && (smiles - currentSmile)%(currentSmile) == 0)
            {
                clipBorad = currentSmile;
                copied = true;
            }
            else
            {
                currentSmile += clipBorad;
                copied = false;
            }

            sec++;
        }

        return sec;
    }
}