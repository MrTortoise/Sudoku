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
            string inputRow = "12345678";
            string row = inputRow + "9";
            Assert.That(row, Is.EqualTo("123456789"));
        }

        [Test]
        public void CompleteAnotherRowWithOneMissingNumber()
        {
            string inputRow = "23456789";
            string row = "1" + inputRow;
            Assert.That(row,Is.EqualTo("123456789"));
        }
        
    }
}
