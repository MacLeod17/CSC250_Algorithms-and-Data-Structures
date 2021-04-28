using System;
using System.Collections.Generic;
using System.Text;

namespace NQueenLab
{
    public static class NQueens
    {
        // Store Solutions at Class Level
        public static List<List<int>> allSolutions = new List<List<int>>();
        public static int N;
        public static int steps;

        public static void SolveQueens(int n)
        {
            N = n;

            FindNQueens(0, new List<int>());
        }

        public static void FindNQueens(int row, List<int> solution)
        {
            if (row >= N)
            {
                // ?
                solution.Add(steps);
                allSolutions.Add(new List<int>(solution));
                solution.RemoveAt(solution.Count - 1);
            }

            // Iterate Columns
            else
            {
                for (int col = 0; col < N; col++)
                {
                    if (IsSafe(solution, col, row))
                    {
                        solution.Add(col);
                        steps++;
                        FindNQueens(row + 1, solution);
                        // Remove Queen?
                        solution.RemoveAt(solution.Count - 1);
                    }
                }
            }
        }

        static bool IsSafe(List<int> solution, int col, int row)
        {
            for (int i=0; i < row; i++)
            {
                // Check Vertical
                if (solution[i] == col) return false;

                // Check Diagonal Up-Left
                //if (solution[i] == -MathF.Abs(col - i)) return false;

                // Check Diagonal Up-Right
                if (solution[i] == MathF.Abs(col - i)) return false;
            }
            
            return true;
        }
    }
}
