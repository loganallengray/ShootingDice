using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public SoreLoserPlayer()
        {
            Dialogue = "Heh... This is going to be E-Z.";
        }

        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            Console.WriteLine("-------------------");

            int myRoll = Roll();
            int otherRoll = other.Roll();

            // for oneHigherPlayer
            if (myRoll == 0)
            {
                myRoll = otherRoll + 1;
            }
            else if (otherRoll == 0)
            {
                otherRoll = myRoll + 1;
            }

            Say(Dialogue);
            Console.WriteLine($"{Name} rolls a {myRoll}");
            other.Say(other.Dialogue);
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                throw new Exception($"{Name}: ME??? LOSE??? NAH... THIS TABLE IS GETTING FLIPPED SON.");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}