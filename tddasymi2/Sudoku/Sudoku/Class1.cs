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

        private readonly SodokuSolver _sodokuSolver = new SodokuSolver();

        private int[,] GenerateSodokuWithBlank(int[,] input, int i, int j)
        {
            int[,] output = (int[,])input.Clone();
            output[i, j] = 0;
            return output;
        }

        [TestCase()]
        public void GivenSodokuWithOneMissingValueSolve()
        {
            var input = GenerateSodokuWithBlank(_goldenMaster, 0,0);

            var solvedSodoku = _sodokuSolver.SolveSodoku(input);
            Assert.That(solvedSodoku, Is.EqualTo(_goldenMaster));
        }

        [TestCase()]
        public void GivenSodokuWithAnotherMissingValueSolve()
        {
            int[,] input = GenerateSodokuWithBlank(_goldenMaster, 0, 1);

            var solvedSodoku = _sodokuSolver.SolveSodoku(input);
            Assert.That(solvedSodoku, Is.EqualTo(_goldenMaster));
        }

        [TestCase()]
        public void GivenSodokuWithTwoMissingValuesSolve()
        {
            int[,] input = GenerateSodokuWithBlank(_goldenMaster, 0, 1);
            input = GenerateSodokuWithBlank(input, 0, 2);

            var solvedSodoku = _sodokuSolver.SolveSodoku(input);
            Assert.That(solvedSodoku, Is.EqualTo(_goldenMaster));
        }
    }
}
