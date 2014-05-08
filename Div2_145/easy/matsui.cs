using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ImageDithering
{
    public int count(string dithered, string[] screen) 
    {
        char pixColor;
        int pixCount = 0;

        for (int c = 0; c < dithered.Length; c++)
        {
            pixColor = dithered[c];
            for (int i = 0; i < screen.Length; i++)
            {
                for (int j = 0; j < screen[i].Length; j++)
                {
                    if (pixColor == screen[i][j]) 
                    {
                        pixCount++;
                    }
                }

            }
        }

        return pixCount;
    }

}