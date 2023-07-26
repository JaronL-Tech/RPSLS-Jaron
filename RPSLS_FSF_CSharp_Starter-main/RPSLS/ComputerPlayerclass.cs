using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class ComputerPlayerclass
    {
        //Member Variabes (HAS A)
        public string name;
        public List<string> gestures;
        public string chosenGesture;
        public int score;

        //Constructor
        public ComputerPlayerclass(string name)
        {
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }

        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture();
        public class Computerplayer : Player
        {
            public Computerplayer(string name) : base(name) { }
            public override void ChooseGesture()
            {
                Console.WriteLine($"The Ai will now pick a Gesture");
                Random random = new Random();
                int randomIndex = random.Next(gestures.Count);
                chosenGesture = gestures[randomIndex];
            }







        } 
        
        
        
      
         
    }
}
