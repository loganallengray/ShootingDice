using System;

namespace ShootingDice
{
    public class Player
    {
        public string Name { get; set; }
        public int DiceSize { get; set; } = 6;
        public string Dialogue { get; set; } = "Let's do it!";

        public virtual int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine($"{Name}: {Dialogue}");
            return new Random().Next(DiceSize) + 1;
        }

        public virtual void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            Console.WriteLine("-------------------");

            int myRoll = Roll();
            Console.WriteLine($"{Name} rolls a {myRoll}");

            int otherRoll = other.Roll();
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
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