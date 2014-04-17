public class ImageDithering
{
    public int count(string dithered, string[] screen)
    {
	int count = 0;
	
        for(int i = 0 ; i < screen.Length; i++)
        {
            for(int j = 0 ; j < screen[i].Length; j++)
            {
		foreach(char c in dithered)
		{
                    if(c == screen[i][j])
                    {
                        count++;
			break;
                    }
                }
            }
        }
        return count;
    }
}