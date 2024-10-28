using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player =0;
            int overs = 0;
            int balls = 0;
            const int ballsPerOver = 6;
            bool isOut = false;
            Random rand = new Random();

            while (!isOut)
            {
                Console.WriteLine("Enter yout run , 0 : No ball : ");
                int run = int.Parse(Console.ReadLine());

                int computerRun = rand.Next(1, 7);

                if (run == 0)
                {
                    Console.WriteLine("no ball");
                    player++;
                }

                balls++;
                if( balls > ballsPerOver )
                {
                    overs++;
                    balls = 1;
                }

                Console.WriteLine($"Computer run: {computerRun}");
                if ( run == computerRun )
                {
                    isOut = true;
                    Console.WriteLine("OUT");
                }
                else
                {
                    player += run;
                    Console.WriteLine($"Your score: {player}");
                    Console.WriteLine($"Overs: {overs}.{balls}");
                }
            }
            Console.WriteLine($"Game Over! Your final score: {player}");
        }
    }
   
}
