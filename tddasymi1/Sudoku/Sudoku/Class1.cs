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
        public void CompleteARowWithOneMissingNumber()
        {
            string inputRow = "12345678";
            string row = inputRow + "9";
            Assert.That(row, Is.EqualTo("123456789"));
        }
        
    }
}
