using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player options
            Console.WriteLine("Your name? :");
            string playerName = Console.ReadLine();

            Console.WriteLine("Your catchphrase? :");
            string playerDialogue = Console.ReadLine();

            // Human Player is created
            Player player1 = new HumanPlayer(playerDialogue);
            player1.Name = playerName;

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            Player smackTalker = new SmackTalkingPlayer();
            smackTalker.Name = "Medium Mouth";

            Player creativeSmackTalker = new CreativeSmackTalkingPlayer();
            creativeSmackTalker.Name = "Big Mouth";

            Player oneHigher = new OneHigherPlayer();
            oneHigher.Name = "Johnny";

            Player upperHalf = new UpperHalfPlayer();
            upperHalf.Name = "Snooty Tootkins";

            Player soreLoser = new SoreLoserPlayer();
            soreLoser.Name = "Logan";

            Player soreLoserUpper = new SoreLoserUpperHalfPlayer();
            soreLoserUpper.Name = "Logan 2.0";

            player1.Play(smackTalker);
            player1.Play(creativeSmackTalker);
            player1.Play(large);
            player1.Play(oneHigher);
            player1.Play(upperHalf);

            try
            {
                player1.Play(soreLoser);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                player1.Play(soreLoserUpper);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<Player> players = new List<Player>() {
                player1, player2, player3, smackTalker, creativeSmackTalker, large, oneHigher, soreLoser, upperHalf, soreLoserUpper
            };

            try
            {
                PlayMany(players);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}