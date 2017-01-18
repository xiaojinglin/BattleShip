using System;
using System.Collections.Generic;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the board size
            const int size = 3;
            Board board = new Board(size);

            //Because it is a single player game, you play against computer. So let computer initalize itself.
            Random random = new Random();
            Player computer = new Player();
            Ship computerShip = new Ship();
            computerShip.ShipLocation = new Point(random.Next(size), random.Next(size));
            computer.setShip = computerShip;
            int computerHit = 0;
            List<Point> computerRecord = new List<Point>(size * size);

            //Player's initalization
            Player player = new Player();
            Ship playerShip = new Ship();
            Location location = new Location();
            Console.WriteLine("Please set your ship location:");
            playerShip.ShipLocation = location.GetLocation(board);
            player.setShip = playerShip;
            int playerHit = 0;
            List<Point> playerRecord = new List<Point>(size * size);

            string result = "";

            //Start guessing locations
            while (true)
            {
                //Set computer's hit location
                Point computerHitLocation = new Point(random.Next(size), random.Next(size));

                //Player set the hit location
                Console.WriteLine("Please set your hit location:");               
                Point playerHitLocation = location.GetLocation(board);

                //Check whether player hit the computer's ship
                switch (computer.isHited(playerHitLocation, playerRecord))
                {
                    case 0:
                        playerHit++;
                        Console.WriteLine("Your can't hit the same location twice! ");
                        Console.WriteLine("You lost " + playerHit + " hits");
                        break;
                    case 1:
                        result = "You won!";
                        break;
                    case 2:
                        playerHit++;
                        playerRecord.Add( playerHitLocation);
                        Console.WriteLine("Your lost " + playerHit + " hits");
                        break;
                }

                //Check whether computer hit player's ship
                switch (player.isHited(computerHitLocation, computerRecord))
                {
                    case 0:
                        computerHit++;
                        Console.WriteLine("Computer lost " + computerHit + " hits");
                        break;
                    case 1:
                        result = "You lost!";
                        break;
                    case 2:
                        computerHit++;
                        computerRecord.Add(computerHitLocation);
                        Console.WriteLine("Computer lost " + computerHit + " hits");
                        break;
                }

                if(result == "You won!" || result == "You lost!")
                {
                    break;
                }

            }

            Console.WriteLine(result);

        }
    }
}
