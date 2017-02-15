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
                    return inputRow.Replace("_", i.ToString());
                }
            }
            return "borked";
        }
    }
}