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
        [Test]
        public void CompleteARowWithOneMissingNumber()
        {
            string inputRow = "12345678_";
            string row = CompleteRow(inputRow);
            Assert.That(row, Is.EqualTo("123456789"));
        }

        private string CompleteRow(string inputRow)
        {
            return "123456789";
        }

        [Test]
        public void CompleteAnotherRowWithOneMissingNumber()
        {
            string inputRow = "_23456789";
            string row = CompleteRow(inputRow);
            Assert.That(row,Is.EqualTo("123456789"));
        }
        
    }
}
