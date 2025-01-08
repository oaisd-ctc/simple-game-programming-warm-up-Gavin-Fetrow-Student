using System;

class Program
{
    public static void Main(string[] args)
    {
        RoundNumber(1);
    }

    public static void RoundNumber(int roundNumber)
    {
        roundNumber = 0;
        int rivalScore = 0;
        int playerScore = 0;
        while (roundNumber < 11)
        {
            if (roundNumber == 0)
            {
                Console.WriteLine("Dice Game");
                Console.WriteLine();
                Console.WriteLine("In this game you and a computer Rival will play 10 rounds");
                Console.WriteLine("where you will each roll a 6-sided dice, and the player");
                Console.WriteLine("with the highest dice value will win the round. The player");
                Console.WriteLine("who wins the most rounds wins the game. Good luck!");
                Console.WriteLine();
                Console.WriteLine("Press any key to start...");
                Console.ReadKey(true);
                roundNumber++;
            }
            
            Random rival = new Random();
            int rivalRoll = rival.Next(1,7);
            Random player = new Random();
            int playerRoll = player.Next(1,7);

            Console.WriteLine();
            Console.WriteLine("Round " + roundNumber);
            Console.WriteLine("Rival rolled a " + rivalRoll);
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadKey(true);
            Console.WriteLine("You rolled a " + playerRoll);

            if (playerRoll > rivalRoll)
            {
                Console.WriteLine("You won this round.");
                playerScore++;
            }
            else if (rivalRoll > playerRoll)
            {
                Console.WriteLine("The Rival won this round.");
                rivalScore++;
            }
            else
            {
                Console.WriteLine("This round is a draw!");
            }

            Console.WriteLine("The score is now - You : " + playerScore + ". Rival : " + rivalScore  + ".");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            roundNumber++;
            
            if (roundNumber == 11)
            {
                Console.WriteLine();
                Console.WriteLine("Game over.");
                Console.WriteLine("The score is now - You : " + playerScore + ". Rival : " + rivalScore  + ".");
                if (playerScore > rivalScore)
                {
                    Console.WriteLine("You won!");
                }
                else if (rivalScore > playerScore)
                {
                    Console.WriteLine("You lost!");
                }
                else
                {
                    Console.WriteLine("This game is a draw.");
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey(true);
            }
        }
    }
}