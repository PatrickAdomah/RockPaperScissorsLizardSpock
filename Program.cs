using System;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] choice = { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };

            Random rnd = new Random();
            int computer_choice = rnd.Next(0,4);

            Console.WriteLine("Welcome to Rock paper scissors lizard spock");
            Console.WriteLine("Computer has made a choice");

            Console.Write("Player 1, Make your choice: ");
            string player1 = Console.ReadLine().ToUpper();

            if (player1 == choice[computer_choice])
            {
                Console.WriteLine("Draw");
            }
            else if (player1 == "ROCK" && choice[computer_choice] == "PAPER" )
            {
                Console.WriteLine("Computer");
            }
            else if (player1 == "ROCK" && choice[computer_choice] == "SPOCK")
            {
                Console.WriteLine("Computer");
            }

            else if (player1 == "ROCK" && choice[computer_choice] == "SCISSOR")
            {
                Console.WriteLine("Human");
            }
            else if (player1 == "ROCK" && choice[computer_choice] == "LIZARD")
            {
                Console.WriteLine("Human");
            }

            else if (player1 == "PAPER" && choice[computer_choice] == "ROCK")
            {
                Console.WriteLine("Human");
            }
            else if (player1 == "PAPER" &&  choice[computer_choice] == "SPOCK")
            {
                Console.WriteLine("Human");
            }

            else if (player1 == "PAPER" && choice[computer_choice] == "SCISSOR")
            {
                Console.WriteLine("Computer");
            }
            else if (player1 == "PAPER" && choice[computer_choice] == "LIZARD")
            {
                Console.WriteLine("Computer");
            }

            else if (player1 == "SCISSOR" && choice[computer_choice] == "PAPER" || choice[computer_choice] == "LIZARD")
            {
                Console.WriteLine("Human");
            }
            else if (player1 == "SCISSOR" && choice[computer_choice] == "LIZARD")
            {
                Console.WriteLine("Human");
            }

            else if (player1 == "SCISSOR" && choice[computer_choice] == "ROCK")
            {
                Console.WriteLine("Computer");
            }
            else if (player1 == "SCISSOR" && choice[computer_choice] == "SPOCK")
            {
                Console.WriteLine("Computer");
            }

            else if (player1 == "LIZARD" && choice[computer_choice] == "PAPER")
            {
                Console.WriteLine("Human");
            }
            else if (player1 == "LIZARD" && choice[computer_choice] == "SPOCK")
            {
                Console.WriteLine("Human");
            }
            else if (player1 == "LIZARD" && choice[computer_choice] == "ROCK" )
            {
                Console.WriteLine("Computer");
            }
            else if (player1 == "LIZARD" && choice[computer_choice] == "SCISSOR")
            {
                Console.WriteLine("Computer");
            }

            else if (player1 == "SPOCK" && choice[computer_choice] == "ROCK")
            {
                Console.WriteLine("Human");
            }
            else if (player1 == "SPOCK" && choice[computer_choice] == "SCISSORS")
            {
                Console.WriteLine("Human");
            }
            else if (player1 == "SPOCK" && choice[computer_choice] == "PAPER" )
            {
                Console.WriteLine("Computer");
            }
            else if (player1 == "SPOCK" && choice[computer_choice] == "LIZARD")
            {
                Console.WriteLine("Computer");
            }

            else
            {
                Console.WriteLine("Invaild entry");
            }

            Console.WriteLine("Computer choice was: {0}", choice[computer_choice]);
        }
    }
}
