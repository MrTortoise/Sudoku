using System;

namespace Sudoku
{
    public class SudokuSolver
    {
        public string CompleteRow(string inputRow)
        {
            for (int i = 1; i < 10; i++)
            {
                if (!inputRow.Contains(i.ToString()))
                {
                    int index = inputRow.IndexOf("_", StringComparison.Ordinal);
                    if (index == 0)
                    {
                        inputRow = i + inputRow.Substring(1);
                    }
                    else if (index == inputRow.Length - 1)
                    {
                        inputRow = inputRow.Substring(0, inputRow.Length - 1) + i;
                    }
                    else
                    {
                        var start = inputRow.Substring(0, index);
                        var end = inputRow.Substring(index+1);
                        inputRow = start + i + end;
                    }
                }
            }
            return inputRow;
        }
    }
}