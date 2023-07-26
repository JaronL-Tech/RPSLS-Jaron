using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayerclass
    {
    }
    namespace RPSLS
    {
        internal abstract class Player
        {
            //Member Variabes (HAS A)
            public string name;
            public List<string> gestures;
            public string chosenGesture;
            public int score;

            //Constructor
            public Player(string name)
            {
                this.name = name;
                gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
                chosenGesture = "";
                score = 0;
            }

            //Member Methods (CAN DO)
            //This abstract method must be overridden by the child Player classes
            public abstract void ChooseGesture();
            public class HumanPlayer : Player
            {
                public HumanPlayer(string name) : base(name)
                {
                }

                public override void ChooseGesture()
                {
                    Console.WriteLine($"{name}, please choose one of the following gestures:");

                    // Display the list of possible gestures to the player
                    for (int i = 0; i < gestures.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {gestures[i]}");
                    }

                    // Ask the player to choose a gesture
                    int choice;
                    do
                    {
                        Console.Write("Enter the number of your chosen gesture: ");
                    } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > gestures.Count);

                    // Save the player's choice in the chosenGesture member variable
                    chosenGesture = gestures[choice - 1];
                }
            }









        }
    }
}
