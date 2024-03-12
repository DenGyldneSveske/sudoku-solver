// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        //program execution starts from here
        int[,] grid = { { 0, 0, 7, 6, 0, 0, 2, 5, 4 },
                        { 0, 0, 2, 0, 1, 0, 0, 0, 0 },
                        { 0, 6, 0, 0, 2, 7, 9, 1, 3 },
                        { 0, 0, 0, 8, 7, 0, 0, 0, 5 },
                        { 0, 5, 0, 3, 4, 0, 7, 0, 0 },
                        { 4, 7, 3, 2, 0, 6, 0, 0, 0 },
                        { 7, 3, 4, 5, 9, 0, 0, 6, 2 },
                        { 2, 1, 0, 0, 0, 0, 0, 3, 2 },
                        { 6, 0, 0, 0, 0, 2, 0, 7, 0 } };

        SudokuSolver sudokuSolver = new SudokuSolver(grid);
        sudokuSolver.solveSudoku(0, 0);
        sudokuSolver.printGrid();
    }
}