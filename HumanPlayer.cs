namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public HumanPlayer(string playerDialogue, int playerChoice)
        {
            Dialogue = playerDialogue;
            DiceSize = playerChoice;
        }
    }
}