using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
  
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
