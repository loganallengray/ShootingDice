using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public SoreLoserUpperHalfPlayer()
        {
            Dialogue = "Just so you know, if you beat me I'm actually going to cry.";
        }

        public override int Roll()
        {
            int rand = new Random().Next(DiceSize) + 1;

            // if rand is less than 4, it will be incremented by three
            if (rand < 4)
            {
                rand += 3;
            }

            return rand;
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
                throw new Exception($"{Name}: You CAN'T beat me I RIGGED these dice in MY favor, oh GOD here come the tears.");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}