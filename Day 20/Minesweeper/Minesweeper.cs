using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public enum CellState { Point1, Point2, Mine }

    public class Minesweeper
    {
        private CellState[,] grid;
        private char[,] displayGrid;

        public Minesweeper()
        {
            grid = new CellState[5, 5];
            displayGrid = new char[5, 5];
            InitGrid();
        }

        private void InitGrid()
        {
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var state = (CellState)random.Next(0, 3); // 0 for Point1, 1 for Point2, 2 for Mine
                    grid[i, j] = state;
                    displayGrid[i, j] = '*'; // Initialize display grid to asterisks
                }
            }
        }

        public void Play()
        {
            bool isPlayer1Turn = true;
            while (true)
            {
                Console.Clear();
                RenderGrid();
                Console.WriteLine(isPlayer1Turn ? "Player 1's Turn" : "Player 2's Turn");
                Console.Write("Enter row (0 to 4): ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Enter col (0 to 4): ");
                int col = int.Parse(Console.ReadLine());

                if (grid[row, col] == CellState.Mine)
                {
                    RevealMines(); // Reveal all mines
                    RenderGrid();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ResetColor();
                    break;
                }
                else
                {
                    int points = CountPointsAround(row, col);
                    displayGrid[row, col] = points.ToString()[0]; // Reveal number
                }

                isPlayer1Turn = !isPlayer1Turn;
            }
        }

        private void RenderGrid()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (displayGrid[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // Red for mine
                    }
                    else if (char.IsDigit(displayGrid[i, j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Green for numbers
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.Write($"{displayGrid[i, j]} ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        private void RevealMines()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (grid[i, j] == CellState.Mine)
                    {
                        displayGrid[i, j] = 'X'; // Mark mines with 'X'
                    }
                }
            }
        }

        private int CountPointsAround(int row, int col)
        {
            int count = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i >= 0 && i < 5 && j >= 0 && j < 5 && !(i == row && j == col))
                    {
                        if (grid[i, j] == CellState.Point1 || grid[i, j] == CellState.Point2)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
