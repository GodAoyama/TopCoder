using System;
public class BombSweeper
{

    private bool NoBomb(int x, int y, string[] board)
    {
        for(int i = -1; i <= 1; i++)
        {
            for(int j = -1; j<=1; j++)
            {
                if (i+x < 0 || j+y < 0 || board.Length <= i+x || board[0].Length <= j+y)
                    continue;
                if (board[i+x][j+y] == 'B')
                    return false;
            }
        }

        return true;
    }
    public double winPercentage(string[] board)
    {
        double lose = 0;
        double win = 0;
        for (int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == 'B')
                    lose++;
                else if (NoBomb(i, j, board))
                    win++;
            }
        }

        return win / (lose + win)*100;
    }
}