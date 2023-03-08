using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<string> Insults = new List<string> {
            "You throw dice like someone who is BAD at throwing DICE.",
            "Quite frankly I do not like you, Frank.",
            "If you love dice so much, why don't you talk to a therapist about it?"
        };

        public CreativeSmackTalkingPlayer()
        {
            Dialogue = Insults[randomNum()];
        }

        int randomNum()
        {
            return new Random().Next(Insults.Count);
        }
    }
}