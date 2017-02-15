using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sudoku
{
    [TestFixture]
    public class Tests
    {
        private readonly SudokuSolver _sudokuSolver = new SudokuSolver();

        [TestCase("12345678_", "123456789")]
        [TestCase("_23456789", "123456789")]
        [TestCase("234_56789", "234156789")]
        public void CompleteRowTests(string input, string expected)
        {
            string actual = _sudokuSolver.CompleteRow(input);
            Assert.That(actual,Is.EqualTo(expected));
        }
    }
}