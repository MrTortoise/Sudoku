using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sudoku
{
    [TestFixture]
    public class SomeTests
    {
        private readonly int[,] _goldenMaster = new int[,]
            {
                {4, 6, 7, 8, 9, 1, 2, 3, 5},
                {9, 1, 5, 3, 2, 4, 7, 8, 6},
                {8, 2, 3, 6, 5, 7, 9, 4, 1},
                {1, 8, 6, 2, 7, 9, 4, 5, 3},
                {5, 3, 9, 1, 4, 6, 8, 2, 7},
                {7, 4, 2, 5, 3, 8, 1, 6, 9},
                {3, 9, 1, 4, 6, 2, 5, 7, 8},
                {2, 5, 8, 7, 1, 3, 6, 9, 4},
                {6, 7, 4, 9, 8, 5, 3, 1, 2}
            };

        private int[,] GenerateSodokuWithBlank(int i, int j)
        {
            int[,] input = (int[,])_goldenMaster.Clone();
            input[i, j] = 0;
            return input;
        }

        [TestCase()]
        public void GivenSodokuWithOneMissingValueSolve()
        {
            var input = GenerateSodokuWithBlank(0,0);

            var solvedSodoku = SolveSodoku(input);
            Assert.That(solvedSodoku, Is.EqualTo(_goldenMaster));
        }

        private int[,] SolveSodoku(int[,] input)
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

            foreach (Tuple<int, int> point in pointsToSolve)
            {
                List<int> possibleRowValues = GetPossibleRowValues(input, point.Item1);
                if (possibleRowValues.Count == 1)
                {
                    beingSolved[point.Item1, point.Item2] = possibleRowValues[0];
                }
            }

            return beingSolved;
        }

        private List<int> GetPossibleRowValues(int[,] input, int rowIndex)
        {
            int[] row = new int[9];
            for (int i = 0; i < 9; i++)
            {
                row[i] = input[rowIndex, i];
            }

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

        [TestCase()]
        public void GivenSodokuWithAnotherMissingValueSolve()
        {
            int[,] input = GenerateSodokuWithBlank(0, 1);

            var solvedSodoku = SolveSodoku(input);
            Assert.That(solvedSodoku, Is.EqualTo(_goldenMaster));
        }
    }
}
