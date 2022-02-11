using System;
using System.Collections.Generic;

namespace EightQueens
{
    class Program
    {
        const int Size = 8;
        static int[,] matrix = new int[Size, Size];
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedCol = new HashSet<int>();
        static HashSet<int> LeftDia = new HashSet<int>();
        static void Main(string[] args)
        {
            PlaceQueens(0);
        }
        static void PlaceQueens(int row)
        {
            if (row == Size)
            {
                PrinstSolution();
            }
            for(int col = 0; col < Size; col++)
            {
                if(CanPlaceQueen(row, col))
                {
                    MarkAttackedPosition(row, col);
                    PlaceQueens(row + 1);
                    UnMarkAttackedPosition(row, col);
                }
            }
        }

        private static void UnMarkAttackedPosition(int row, int col)
        {
            throw new NotImplementedException();
        }

        private static void MarkAttackedPosition(int row, int col)
        {
            throw new NotImplementedException();
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            bool isFreePosition = attackedRows.Contains(row);
        }

        private static void PrinstSolution()
        {
            for(int r = 0; r < Size ; r++)
            {
                for(int c = 0; c < Size; c++)
                {
                    if(matrix[r, c] == 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
