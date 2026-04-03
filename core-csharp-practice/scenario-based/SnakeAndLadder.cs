/*This program implements a console-based Snake and Ladder game in C# supporting 2 to 4 players. 
 * Player details (name, old position, new position) are stored in a 2D string array. 
 * The game uses a 100-cell board, dice rolls from 1 to 6, and fixed snake and ladder positions. 
 * Players take turns rolling the dice, moving forward, and applying snake or ladder rules. 
 * If a move exceeds 100, the turn is skipped, and the first player to reach exactly position 100 wins. 
 * The code is modular, using separate methods for starting the game, handling players, rolling dice, moving players, applying snakes or ladders, and checking the win condition.
*/

using System;

namespace BridgeLabzTraining.Senario_based
{
    internal class SnakeAndLadder
    {
        Random rand = new Random();

        // Snakes and Ladders
        int[] start = { 4, 9, 17, 20, 28, 40, 51, 63, 89, 95, 99 };
        int[] end = { 14, 31, 7, 38, 84, 59, 67, 81, 26, 75, 78 };

        public void Start()
        {
            Console.WriteLine("--------------- Welcome to Snake & Ladder ---------------");
            NumberOfPlayers();
        }

        public void NumberOfPlayers()
        {
            //taking number of players from the user
            Console.Write("Enter number of players (2-4): ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 2 || num > 4)
            {
                Console.WriteLine("Invalid number of players");
                return;
            }

            // [name, oldPosition, newPosition]
            string[,] players = new string[num, 3];

            Console.WriteLine("Enter player names:");
            for (int i = 0; i < num; i++)
            {
                players[i, 0] = Console.ReadLine();
                players[i, 1] = "0";
                players[i, 2] = "0";
            }

            PlayGame(players, num);
        }

        //method to play game
        public void PlayGame(string[,] players, int count)
        {
            bool isWinner = false;

            while (!isWinner)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\n-----------------------------------");
                    Console.WriteLine("Player Turn: " + players[i, 0]);

                    int oldPos = Convert.ToInt32(players[i, 2]);
                    int dice = RollDice();

                    Console.WriteLine("Dice Value: " + dice);

                    int newPos = MovePlayer(oldPos, dice);

                    if (newPos > 100)
                    {
                        Console.WriteLine("Move exceeds 100. Turn skipped.");
                        continue;
                    }

                    newPos = ApplySnakeOrLadder(newPos);

                    players[i, 1] = oldPos.ToString();
                    players[i, 2] = newPos.ToString();

                    Console.WriteLine("Position: " + oldPos + " to " + newPos);

                    if (CheckWin(newPos))
                    {
                        Console.WriteLine(players[i, 0] + " wins the game!");
                        isWinner = true;
                        break;
                    }
                }
            }
        }

        //method to roll dice using random class
        public int RollDice()
        {
            return rand.Next(1, 7);
        }

        //method for updating the position
        public int MovePlayer(int currentPos, int dice)
        {
            return currentPos + dice;
        }

        //method for checking of snakes or ladders
        public int ApplySnakeOrLadder(int position)
        {
            for (int i = 0; i < start.Length; i++)
            {
                if (position == start[i])
                {
                    bool isLadder = start[i] < end[i] ? true : false;

                    if (isLadder)
                    {
                        Console.WriteLine("Ladder found. Moving up.");
                    }
                    else
                    {
                        Console.WriteLine("Snake found. Moving down.");
                    }


                    position = end[i];
                    break;
                }
            }
            return position;
        }

        //method if the player wins or not
        public bool CheckWin(int position)
        {
            if (position == 100)
            {
                return true;
            }
             return false;
            
        }
    }
}
