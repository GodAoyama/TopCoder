public class Time
{
    public string whatTime(int seconds) 
    {
        int hour;
        int min;
        int sec;
        string returnString = "";
        hour = (int)(seconds / 3600);
        min = (int)((seconds - hour * 3600) / 60);
        sec = (int)(seconds - hour *3600 - min * 60);

        returnString = hour.ToString() + ":" + min.ToString() + ":" + sec.ToString();

        return returnString;
    }

}