public class TheBlackJackDivTwo
{
    public int score(string[] cards)
    {
        int score = 0;
    
        foreach(string v in cards)
        {
            switch(v[0])
            {
                case 'A':
                    score += 11;
                    break;
                case 'T':
                    score += 10;
                    break;
                case 'J':
                    score += 10;
                    break;
                case 'Q':
                    score += 10;
                    break;
                case 'K':
                    score += 10;
                    break;
                default :
                    score += (int)(v[0]-'0');
                    break;
            }
        }
    
        return score;
    }
}