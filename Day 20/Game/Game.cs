using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Game
    {
        private Player player;
        private Computer computer;
        private Random rand;
        private Dictionary<int, string> options;

        public Game(string playerName)
        {
            player = new Player(playerName);
            computer = new Computer();
            rand = new Random();
            options = new Dictionary<int, string>
            {
                { 1, "Rock"},
                { 2, "Paper"},
                { 3, "Scissor"}
            };
        }

        private void Winner(int playerChoice , int computerChoice)
        {
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("TIE");
            }
            else if (
                (playerChoice == 2 && computerChoice == 1) ||
                (playerChoice == 3 && computerChoice == 2) ||
                (playerChoice == 1 && computerChoice == 3) )
            {
                Console.WriteLine("Player win's the round");
                player.Score++;
            }
            else
            {
                Console.WriteLine("Computer win's the round");
                computer.Score++;
            }
        }

        public void Play()
        {
            while (player.Score < 10 && computer.Score < 10)
            {
                Console.WriteLine($"{player.Name}, choose 1 for Rock, 2 for Paper, or 3 for Scissors: ");
                if(!int.TryParse(Console.ReadLine(), out int playerChoice) || playerChoice < 1 || playerChoice > 3)
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }

                int computerChoice = rand.Next(1, 4);
                Console.WriteLine($"{player.Name} chose: {options[playerChoice]}");
                Console.WriteLine($"Computer chose: {options[computerChoice]}");

                Winner(playerChoice, computerChoice);

                Console.WriteLine($"{player.Name}'s score: {player.Score}");
                Console.WriteLine($"Computer's score: {computer.Score}");
                Console.WriteLine();
            }
        }
    }
}
