using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var names = new List<string>() { "Rock", "Paper", "Scissors" };

            Console.WriteLine("Let's Play Rock Paper Scissors!");
            Console.WriteLine();
            Console.WriteLine("Enter Rock, Paper, or Scissors: ");

            var index = random.Next(names.Count);
            var pcAnswer = names[index];


            var answer = "";

            do
            {
                Console.WriteLine("Invalid answer.");

                Console.WriteLine("Enter Rock, Paper, or Scissors: ");
                answer = Console.ReadLine();

            }
            while (string.IsNullOrEmpty(answer) && !names.Select(x => x.ToLower()).Contains(answer.ToLower()));







            Console.WriteLine("PC answer: " + pcAnswer);



            if (answer == names[0].ToLower() && pcAnswer == names[2])

            {
                Console.WriteLine("You win!");
            }
            else if (answer == names[1].ToLower() && pcAnswer == names[0])
            {
                Console.WriteLine("You win!");
            }
            else if (answer == names[2].ToLower() && pcAnswer == names[1])

            {
                Console.WriteLine("You win!");
            }
            else if (answer == pcAnswer.ToLower())
            {
                Console.WriteLine("No winner.");
            }
            else { Console.WriteLine("You lose."); }










        }
    }
}
