using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public OneHigherPlayer()
        {
            Dialogue = "You've already lost.";
        }

        public override int Roll()
        {
            // Return one higher than the other player's roll
            return 0;
        }
    }
}
