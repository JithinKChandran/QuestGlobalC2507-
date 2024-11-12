using System;

namespace Que3SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int boardSize = 100;

            int player1Position = 0;
            int player2Position = 0;
            Random rand = new Random();

            int[] board = new int[boardSize + 1];
            for (int i = 0; i <= boardSize; i++)
            {
                board[i] = i;
            }

            // Ladders
            board[3] = 38;
            board[28] = 84;
            board[36] = 44;
            // Snakes
            board[49] = 11;
            board[56] = 53;
            board[62] = 19;
            board[87] = 24;
            board[93] = 73;
            board[98] = 2;

            bool gameWon = false;
            bool player1Turn = true;

            while (!gameWon)
            {
                if (player1Turn)
                {
                    player1Position = MovePlayer(player1Position, rand, board, "Player 1");
                    if (player1Position >= 100)
                    {
                        Console.WriteLine("Player 1 WINS!");
                        gameWon = true;
                    }
                }
                else
                {
                    player2Position = MovePlayer(player2Position, rand, board, "Player 2");
                    if (player2Position >= 100)
                    {
                        Console.WriteLine("Player 2 WINS!");
                        gameWon = true;
                    }
                }
                // Alternate turns
                player1Turn = !player1Turn;
            }
        }

        static int MovePlayer(int position, Random rand, int[] board, string playerName)
        {
            int cube;
            Console.Write($"{playerName}, press Enter to roll the die.");
            Console.ReadLine();

            cube = rand.Next(1, 7);
            Console.WriteLine($"{playerName} rolled a {cube}");

            if (position == 0 && (cube != 1 && cube != 6))
            {
                Console.WriteLine($"{playerName} needs a 1 or 6 to start. Pass the turn.");
                return 0;
            }

            if (position == 0)
            {
                position = 1;
                Console.WriteLine($"{playerName} starts the game and moves to position 1");
                return position;
            }

            position += cube;

            if (position > 100)
            {
                position = 100;
            }

            Console.WriteLine($"{playerName} moved to {position}");

            if (position != board[position])
            {
                if (position < board[position])
                {
                    Console.WriteLine($"{playerName} got a ladder, climbed from {position} to {board[position]}");
                }
                else
                {
                    Console.WriteLine($"{playerName} got eaten by a snake, slid from {position} to {board[position]}");
                }
                position = board[position];
            }

            Console.WriteLine($"{playerName}'s current position: {position}\n");
            return position;
        }
    }
}
