using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TheMatrix
{
    public static int MaxArea(string[] board)
    {

        int x = board.Length;
        int y = board[0].Length;
        int[,] dif = new int[x, y];

        bool all_same = true;

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[0][0] != board[i][j])
                {
                    all_same = false;
                }
            }
        }
        if (all_same)
        {
            return 1;
        }


        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (i == x - 1 || j == y - 1)
                {
                    dif[i, j] = 0;
                }
                else if (board[i][j] != board[i + 1][j] && board[i][j] != board[i][j + 1] && board[i][j] == board[i + 1][j + 1])
                {
                    dif[i, j] = 1;
                }
                else
                {
                    dif[i, j] = 0;
                }
            }
        }

        int ans = 2;
        int line;
        for (int i = 0; i < x; i++)
        {
            line = 0;
            for (int j = 0; j <= y - 1; j++)
            {
                line++;
                if (j == y - 1)
                {
                    ans = Math.Max(ans, line);
                }
                else if (board[i][j] != board[i][j + 1])
                {
                    continue;
                }
                else
                {
                    ans = Math.Max(ans, line);
                    line = 0;
                }
            }
            ans = Math.Max(ans, line);
        }
        for (int i = 0; i < y; i++)
        {
            line = 0;
            for (int j = 0; j <= x - 1; j++)
            {
                line++;
                if (j == x - 1)
                {
                    ans = Math.Max(ans, line);
                }
                else if (board[j][i] != board[j + 1][i])
                {
                    continue;
                }

                else
                {
                    ans = Math.Max(ans, line);
                    line = 0;
                }
            }
            ans = Math.Max(ans, line);
        }
        int width, height;
        int max = 10000;
        for (int i = 0; i < x - 1; i++)
        {
            for (int j = 0; j < y - 1; j++)
            {
                if (dif[i, j] == 1)
                {
                    height = 0;
                    max = 10000;
                    for (int a = i; a < x - 1; a++)
                    {
                        height++;
                        width = 0;
                        for (int b = j; b < y - 1; b++)
                        {
                            width++;

                            if (width >= max)
                            {
                                ans = Math.Max(ans, (height + 1) * Math.Min((max + 1), (width + 1)));
                                break;
                            }
                            else if (dif[a, b + 1] == 1)
                            {
                                continue;
                            }
                            else
                            {
                                max = width;
                                ans = Math.Max(ans, (height + 1) * Math.Min((max + 1), (width + 1)));
                                break;
                            }
                        }
                        if (dif[a + 1, j] == 1)
                        {
                            continue;
                        }
                        break;
                    }
                }

            }
        }
        return ans;
    }
}