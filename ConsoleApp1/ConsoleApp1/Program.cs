using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver{
    class Program
    {
        static void Main(string[] args)
        {
            //easy
            //int[,] board = new int[,] {
            //    { 0, 0, 3, 2, 0, 0, 0, 1, 0 },
            //    { 0, 1, 0, 0, 6, 9, 0, 7, 5 },
            //    { 0, 9, 6, 0, 7, 5, 3, 0, 2 },
            //    { 0, 6, 0, 0, 5, 0, 0, 0, 8 },
            //    { 0, 8, 0, 0, 3, 6, 2, 4, 9 },
            //    { 0, 7, 0, 9, 0, 0, 0, 0, 0 },
            //    { 0, 0, 1, 0, 0, 7, 0, 9, 0 },
            //    { 0, 0, 0, 0, 0, 0, 5, 2, 7 },
            //    { 8, 2, 7, 0, 9, 0, 1, 6, 3 },
            //};

            //medium
            //int[,] board = new int[,] {
            //    { 9, 6, 0, 4, 0, 1, 3, 0, 0 },
            //    { 0, 7, 0, 9, 0, 0, 5, 6, 0 },
            //    { 0, 0, 0, 7, 0, 0, 0, 2, 0 },
            //    { 4, 0, 6, 1, 0, 0, 0, 0, 0 },
            //    { 0, 0, 8, 0, 6, 0, 0, 0, 0 },
            //    { 0, 0, 0, 0, 4, 8, 1, 0, 6 },
            //    { 5, 0, 0, 6, 0, 7, 9, 0, 0 },
            //    { 0, 0, 0, 0, 0, 0, 2, 0, 7 },
            //    { 8, 2, 0, 0, 0, 0, 6, 0, 3 },
            //};

            //hard
            //int[,] board = new int[,] {
            //    { 0, 1, 0, 0, 0, 8, 9, 0, 0 },
            //    { 7, 0, 3, 4, 0, 0, 0, 0, 5 },
            //    { 0, 0, 0, 0, 6, 0, 0, 0, 4 },
            //    { 0, 9, 0, 0, 0, 5, 0, 0, 8 },
            //    { 0, 8, 0, 0, 0, 0, 0, 0, 0 },
            //    { 0, 5, 7, 8, 3, 0, 0, 0, 6 },
            //    { 0, 0, 2, 0, 0, 0, 0, 3, 0 },
            //    { 8, 0, 0, 0, 5, 0, 0, 0, 0 },
            //    { 0, 0, 0, 0, 1, 3, 0, 2, 0 },
            //};

            //expert
            //int[,] board = new int[,] {
            //    { 0, 7, 8, 5, 0, 0, 0, 0, 0 },
            //    { 0, 0, 3, 0, 0, 7, 8, 0, 0 },
            //    { 0, 0, 0, 1, 9, 0, 0, 0, 0 },
            //    { 0, 0, 7, 0, 0, 0, 2, 9, 0 },
            //    { 0, 9, 0, 0, 6, 1, 0, 4, 0 },
            //    { 0, 0, 0, 0, 0, 4, 0, 0, 0 },
            //    { 3, 0, 6, 0, 0, 2, 0, 0, 0 },
            //    { 0, 1, 0, 0, 0, 0, 0, 0, 4 },
            //    { 0, 0, 0, 0, 0, 0, 5, 0, 0 },
            //};

            //famous
            //int[,] board = new int[,] {
            //    { 0, 1, 0, 0, 0, 0, 0, 0, 0 },
            //    { 0, 0, 2, 0, 0, 0, 0, 0, 0 },
            //    { 0, 0, 0, 3, 0, 0, 0, 0, 0 },
            //    { 1, 0, 0, 0, 4, 0, 0, 0, 0 },
            //    { 0, 7, 0, 0, 0, 5, 0, 0, 0 },
            //    { 0, 0, 8, 0, 0, 0, 6, 0, 0 },
            //    { 0, 0, 0, 4, 0, 0, 0, 1, 0 },
            //    { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            //    { 9, 0, 7, 0, 0, 0, 0, 0, 0 },
            //};

            //famous
            int[,] board = new int[,] {
                { 0, 0, 1, 2, 0, 3, 4, 0, 0 },
                { 0, 0, 0, 6, 0, 7, 0, 0, 0 },
                { 5, 0, 0, 0, 0, 0, 0, 0, 3 },
                { 3, 7, 0, 0, 0, 0, 0, 8, 1 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 6, 2, 0, 0, 0, 0, 0, 3, 7 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 8 },
                { 0, 0, 0, 8, 0, 5, 0, 0, 0 },
                { 0, 0, 6, 4, 0, 2, 5, 0, 0 },
            };

            PrintBoard(board);
            Solve(board);

            

            Console.ReadLine();
        }

        static bool Solve(int[,] board)
        {
            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(board[i,j] == 0)
                    {
                        for(int n=1; n<10; n++)
                        {
                            if (Possible(n, i, j, board))
                            {
                                board[i, j] = n;
                                if (Solve(board))
                                    return true;
                                board[i, j] = 0;
                            }
                        }
                        return false;
                    }
                }
            }

            Console.WriteLine("DONE");
            PrintBoard(board);
            return true;
        }

        static bool Possible(int n, int x, int y, int[,] board)
        {
            for (int i = 0; i < 9; i++)
                if (board[x, i] == n)
                    return false;

            for (int i = 0; i < 9; i++)
                if (board[i, y] == n)
                    return false;

            var x0 = (x / 3) * 3;
            var y0 = (y / 3) * 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[x0 + i, y0 + j] == n)
                        return false;

            return true;
        }

        static void PrintBoard(int[,] board)
        {
            int idxi = 1;
            for (int i = 0; i < 9; i++)
            {
                int idxj = 1;
                for (int j = 0; j < 9; j++)
                {
                    if (idxj % 3 == 0 && idxj < 8)
                        Console.Write($" {board[i, j]} |");
                    else
                        Console.Write($" {board[i, j]} ");
                    idxj++;
                }

                Console.WriteLine();
                if (idxi % 3 == 0 && idxi < 8) {
                    Console.WriteLine(" - - - - - - - - - - - - - -");
                }
                idxi++;
            }
        }
    }
}
