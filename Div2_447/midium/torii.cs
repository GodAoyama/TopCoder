
using System;

public class KnightsTour
{
    const int Columns = 8;
    const int Rows = 8;

    Tuple<int, int> nextPos = new Tuple<int, int>(0, 0);
    bool[,] visited = new bool[Rows, Columns];

    private Tuple<int, int> mkTuple(int x, int y)
    {
        return new Tuple<int, int>(x, y);
    }

    private bool CanMove(Tuple<int, int> pos,string[] board)
    {
        int cost = int.MaxValue;

        for (int ri =  - 2; ri <= 2; ri++)
        {
            if (ri == 0)
                continue;
            for (int ci = -2; ci <= 2; ci++)
            {
                int r = pos.Item1 + ri;
                int c = pos.Item2 + ci;
                if (ci == 0 || Math.Abs(ri) == Math.Abs(ci) || r < 0 || Rows <= r || c < 0 || Columns <= c)
                    continue;

                if (!visited[r,c] && board[r][c] == '.')
                {
                    int tmpCost = Accessibility(r, c,board);
                    if(tmpCost <= cost)
                    {
                        if (tmpCost == cost)
                        {
                            if(nextPos.Item1 == r)
                            {
                                if(c <= nextPos.Item2)
                                    continue;
                            }
                        }
                        else
                        {
                            cost = tmpCost;
                            nextPos = mkTuple(r, c);
                        }
                    }
                }
            }
        }

        if (cost != int.MaxValue)
        {
            visited[nextPos.Item1, nextPos.Item2] = true;
            return true;
        }
        return false;
    }

    private int Accessibility(int r, int c,string[] board)
    {
        int access = 0;
        for (int ri = -2; ri <= 2; ri++)
        {
            if (ri == 0)
                continue;
            for (int ci = -2; ci <= 2; ci++)
            {
                int rx = r + ri;
                int cy = c + ci;
                if (ci == 0 || Math.Abs(ri) == Math.Abs(ci) || rx < 0 || Rows <= rx || cy < 0 || Columns <= cy)
                    continue;
                else if (!visited[rx,cy] && board[rx][cy] == '.')
                    access++;
            }
        }
        return access;
    }

    private Tuple<int, int> Initialize(string[] board)
    {
        Tuple<int, int> firstPos = new Tuple<int, int>(0, 0);

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                if (board[i][j] == 'K')
                {
                    firstPos = mkTuple(i, j);
                    visited[i, j] = true;
                }
                else
                    visited[i, j] = false;
            }
        }
        return firstPos;
    }

    public int visitedPositions(string[] board)
    {
        int count = 1;
        Tuple<int, int> currentPos = Initialize(board);

        while (true)
        {
            if (!CanMove(currentPos,board))
                break;
            currentPos = nextPos;
            count++;
        }
        return count;
    }
}