using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    public class SodokuSolver
    {
        public int[,] SolveSodoku(int[,] input)
        {
            var beingSolved = (int[,])input.Clone();
            List<Tuple<int,int>> pointsToSolve = new List<Tuple<int, int>>();
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i, j] == 0)
                    {
                        pointsToSolve.Add(new Tuple<int, int>(i, j));
                    }
                }
            }
            bool solvedSomething = false;
            foreach (Tuple<int, int> point in pointsToSolve)
            {
                List<int> possibleRowValues = GetPossibleRowValues(input, point.Item1);
                if (possibleRowValues.Count == 1)
                {
                    beingSolved[point.Item1, point.Item2] = possibleRowValues[0];
                    solvedSomething = true;
                }

                List<int> possibleColumnValues = GetPossibleColumnValues(input, point.Item2);
                if (possibleColumnValues.Count == 1)
                {
                    beingSolved[point.Item1, point.Item2] = possibleColumnValues[0];
                    solvedSomething = true;
                }
            }

            if (!solvedSomething && pointsToSolve.Any())
            {
                return new int[0,0];
            }

            if (pointsToSolve.Any())
            {
                beingSolved = SolveSodoku(beingSolved);
            }

            return beingSolved;
        }

        private List<int> GetPossibleColumnValues(int[,] input, int columnIndex)
        {
            int[] column = new int[9];
            for (int i = 0; i < 9; i++)
            {
                column[i] = input[i, columnIndex];
            }

            var possibleValues = GetPossibleValues(column);
            return possibleValues;
        }

        private List<int> GetPossibleRowValues(int[,] input, int rowIndex)
        {
            int[] row = new int[9];
            for (int i = 0; i < 9; i++)
            {
                row[i] = input[rowIndex, i];
            }

            var possibleValues = GetPossibleValues(row);
            return possibleValues;
        }

        private List<int> GetPossibleValues(int[] row)
        {
            List<int> possibleValues = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                if (!row.Contains(i))
                {
                    possibleValues.Add(i);
                }
            }
            return possibleValues;
        }
    }
}