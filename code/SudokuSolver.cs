public class SudokuSolver
{
    private const int NumberOfRows = 9;
    private const int NumberOfColumns = 9;
    private int[,] _grid;
    public int[,] Grid
    {
        get { return _grid; }
        set { _grid = value; }
    }
    public SudokuSolver(int[,] grid)
    {
        Grid = grid;
    }

    public bool solveSudoku(int row, int column)
    {
        if (row == NumberOfRows - 1 && column == NumberOfColumns)
        {
            return true;
        }

        if (column == NumberOfColumns)
        {
            row++;
            column = 0;
        }

        if (Grid[row, column] != 0)
        {
            return solveSudoku(row, column + 1);
        }

        for (int i = 1; i < 10; i++)
        {
            if (isSafe(i, row, column))
            {
                Grid[row, column] = i;
                if (solveSudoku(row, column + 1))
                {
                    return true;
                }
            }
            Grid[row, column] = 0;
        }
        return false;
    }

    private bool isSafe(int value, int row, int column)
    {
        return isRowSafe(value, row) && isColumnSafe(value, column) && isSquareSafe(value, row, column);
    }

    private bool isRowSafe(int value, int row)
    {
        for (int i = 0; i < NumberOfColumns; i++)
        {
            if (Grid[row, i] == value)
            {
                return false;
            }
        }
        return true;
    }

    private bool isColumnSafe(int value, int column)
    {
        for (int i = 0; i < NumberOfRows; i++)
        {
            if (Grid[i, column] == value)
            {
                return false;
            }
        }
        return true;
    }

    private bool isSquareSafe(int value, int row, int column)
    {
        for (int i = row - (row % 3); i < row - (row % 3) + 3; i++)
        {
            for (int j = column - (column % 3); j < column - (column % 3) + 3; j++)
            {
                if (Grid[i, j] == value)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public void printGrid()
    {
        for (int i = 0; i < NumberOfRows; i++)
        {
            for (int j = 0; j < NumberOfColumns; j++)
            {
                Console.Write(Grid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}