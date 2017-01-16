using System;

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
            Point[] computerRecord = new Point[size * size];
            int computerRecordIndex = 0;

            //Player's initalization
            Player player = new Player();
            Location location = new Location();
            int playerHit = 0;           
            Point[] playerRecord = new Point[size * size];
            int playerRecordIndex = 0;
            Console.WriteLine("Please set your ship location:");
            Ship playerShip = new Ship();
            playerShip.ShipLocation = location.GetLocation(board);
            player.setShip = playerShip;

            string result = "";

            //Start guessing locations
            while (true)
            {
                //Set computer's hit location
                Point computerHitLocation = new Point(random.Next(size), random.Next(size));

                //Player set the hit location
                Console.WriteLine("Please set your hit location:");               
                Point PlayerHitLocation = location.GetLocation(board);

                //Check whether player hit the computer's ship
                if (computer.isHited(PlayerHitLocation, playerRecord) == 0)
                {
                    playerHit++;
                    Console.WriteLine("Your can't hit the same location twice! ");
                    Console.WriteLine("You lost " + playerHit + " hits");
                }
                else if (computer.isHited(PlayerHitLocation, playerRecord) == 1)
                {
                    result = "You won!";
                    break;
                }
                else
                {
                    playerHit++;
                    playerRecord[playerRecordIndex] = PlayerHitLocation;
                    playerRecordIndex++;
                    Console.WriteLine("Your lost " + playerHit + " hits");
                }

                //Check whether computer hit player's ship
                if (player.isHited(computerHitLocation, computerRecord) == 0)
                {
                    computerHit++;
                    Console.WriteLine("Computer lost " + computerHit + " hits");
                }
                else if (player.isHited(computerHitLocation, computerRecord) == 1)
                {
                    result = "You lost!";
                    break;
                }
                else
                {
                    computerHit++;
                    computerRecord[computerRecordIndex] = computerHitLocation;
                    computerRecordIndex++;
                    Console.WriteLine("Computer lost " + computerHit + " hits");
                }
            }

            Console.WriteLine(result);

        }
    }
}
