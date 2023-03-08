using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public HumanPlayer(string playerDialogue)
        {
            Dialogue = playerDialogue;
        }

        public override int Roll()
        {
            Console.WriteLine("What's your roll? :");
            string numString = Console.ReadLine();
            int.TryParse(numString, out int num);
            return num;
        }
    }
}