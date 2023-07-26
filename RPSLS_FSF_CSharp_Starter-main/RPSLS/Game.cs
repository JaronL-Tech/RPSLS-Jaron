using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS!");
            Console.WriteLine("This game is a true test of skills and strategy ");
            Console.WriteLine("The rules are simple Rock crushes Scissors\nScissors cuts Paper \nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n ");
            Console.WriteLine("The first competitor to reach 3 points wins the game!");
        }

        public int ChooseNumberOfHumanPlayers() 
        {
            int numbersofplayers;
            Console.WriteLine("How many Players? (Enter 1 or 2)");
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out numbersofplayers))
                {
                    if (numbersofplayers == 1 || numbersofplayers == 2)
                    {
                        return numbersofplayers;
                    }

                }
            }
        }






        public void CreatePlayerObjects(int numberOfHumanPlayers)

        { 
        }
        private Player player1;
        private Player player2;

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void CompareGestures()
        {
            Console.WriteLine($"{player1.name} chose {player1.chosenGesture}");
            Console.WriteLine($"{player2.name} chose {player2.chosenGesture}");

            int result = CompareGestures(player1.chosenGesture, player2.chosenGesture);

            if (result == 1)
            {
                Console.WriteLine($"{player1.name} wins the round!");
                player1.score++;
            }
            else if (result == -1)
            {
                Console.WriteLine($"{player2.name} wins the round!");
                player2.score++;
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        private int CompareGestures(string gesture1, string gesture2)
        {
            if (gesture1 == gesture2)
            {
                return 0; // Tie
            }
            else if (
                (gesture1 == "rock" && (gesture2 == "scissors" || gesture2 == "lizard")) ||
                (gesture1 == "paper" && (gesture2 == "rock" || gesture2 == "Spock")) ||
                (gesture1 == "scissors" && (gesture2 == "paper" || gesture2 == "lizard")) ||
                (gesture1 == "lizard" && (gesture2 == "Spock" || gesture2 == "paper")) ||
                (gesture1 == "Spock" && (gesture2 == "scissors" || gesture2 == "rock"))
            )
            {
                return 1; // Player 1 wins
            }
            else
            {
                return -1; // Player 2 wins
            }
        }

        public void DisplayGameWinner()
        {
            if (player1.score >= 2)
            {
                Console.WriteLine($"{player1.name} wins the game!");
            }
            else if (player2.score >= 2)
            {
                Console.WriteLine($"{player2.name} wins the game!");
            }
            else
            {
                Console.WriteLine("The game is still ongoing. No winner yet.");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
            CompareGestures();
            DisplayGameWinner();
        }
    }
}
