using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public UpperHalfPlayer()
        {
            Dialogue = "Think you can beat me? Think again.";
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
    }
}