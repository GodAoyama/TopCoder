public class WakingUpEasy
{
    public int countAlarms(int[] volume, int S)
    {
        int sleepness = S;
        int i = 0, count = 0;
        int last = volume.Length-1;
    
        while(true)
        {
            sleepness -= volume[i];			
            count ++;
            if(sleepness <= 0)
                break;
            i = (i+1)%volume.Length;
            last = last == 0 ? volume.Length-1 : last-1;                        
        }
        
        return count;
    }
}