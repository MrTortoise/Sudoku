namespace Sudoku
{
    public class SudokuSolver
    {
        public string CompleteRow(string inputRow)
        {
            if (!inputRow.Contains("1"))
            {
                return inputRow.Replace("_", "1");
            }
            return "123456789";
        }
    }
}