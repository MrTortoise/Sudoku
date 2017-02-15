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
            var solvedSodoku = input;
            solvedSodoku[0, 0] = 4;
            solvedSodoku[0, 1] = 6;
            return solvedSodoku;
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
