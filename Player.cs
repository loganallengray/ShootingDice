using System;

namespace ShootingDice
{
    public class Player
    {
        public string Name { get; set; }
        public int DiceSize { get; set; } = 6;
        public string Dialogue { get; set; } = "Let's do this!";

        public void Say(string text)
        {
            Console.WriteLine($"{Name}: {text}");
        }

        public virtual int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

        public virtual void Play(Player other)
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
                if (other.Dialogue == "Heh... This is going to be E-Z.")
                {
                    throw new Exception($"{other.Name}: ME??? LOSE??? NAH... THIS TABLE IS GETTING FLIPPED SON.");
                }
                else if (other.Dialogue == "Just so you know, if you beat me I'm actually going to cry.")
                {
                    throw new Exception($"{other.Name}: You CAN'T beat me I RIGGED these dice in MY favor, oh GOD here come the tears.");
                }
                else
                {
                    Console.WriteLine($"{Name} Wins!");
                }
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}