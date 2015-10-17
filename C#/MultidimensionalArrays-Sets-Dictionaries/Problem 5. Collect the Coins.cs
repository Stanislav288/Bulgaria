using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[4][];
            int wallsHit = 0;
            int coinsCollected = 0;
            int[] position = { 0, 0 };
            for (int row = 0; row < 4; row++)
            {

                board[row] = Console.ReadLine().ToCharArray();
            }
            char[] moves = Console.ReadLine().ToCharArray();
            if (board[0][0] == '$') { coinsCollected++; }
            for (int direction = 0; direction < moves.Length; direction++)
            {
                if (moves[direction] == '>')
                {
                    if (position[1] + 1 < board[position[0]].Length)
                    {
                        position[1]++;
                        if (board[position[0]][position[1]] == '$')
                        {
                            coinsCollected++;
                        }
                    }
                    else
                    {
                        wallsHit++;
                    }
                }
                if (moves[direction] == '<')
                {
                    if (position[1] - 1 >= 0)
                    {
                        position[1]--;
                        if (board[position[0]][position[1]] == '$')
                        {
                            coinsCollected++;
                        }
                    }
                    else
                    {
                        wallsHit++;
                    }
                }
                if (moves[direction] == '^')
                {
                    if (position[0] - 1 >= 0)
                    {
                        position[0]--;
                        if (board[position[0]][position[1]] == '$')
                        {
                            coinsCollected++;
                        }
                    }
                    else
                    {
                        wallsHit++;
                    }
                }
                if (moves[direction] == 'v')
                {
                    if (position[0] + 1 < 4)
                    {
                        position[0]++;
                        if (board[position[0]][position[1]] == '$')
                        {
                            coinsCollected++;
                        }
                    }
                    else
                    {
                        wallsHit++;
                    }
                }
            }
            Console.WriteLine("Coins collected:  " + coinsCollected);
            Console.WriteLine("Walls hit:   " + wallsHit);
        }
    }
}
