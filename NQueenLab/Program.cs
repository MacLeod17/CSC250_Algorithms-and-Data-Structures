using System;

namespace NQueenLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            NQueens.SolveQueens(n);
        }
    }
}