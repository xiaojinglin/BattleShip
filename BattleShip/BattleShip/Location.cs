using System;

namespace BattleShip
{
    class Location
    {
        public Point GetLocation(Board board)
        {
            while(true)
            {
                //Get a location from the entry and check whether is out of board 
                try
                {
                    Console.WriteLine("Please enter a X-coordinate:");
                    string x = Console.ReadLine();
                    Console.WriteLine("Please enter a Y-coordinate:");
                    string y = Console.ReadLine();
                    Point point = new Point(int.Parse(x), int.Parse(y));
                    if (!board.OnBoard(point))
                    {
                        throw new OutOfBoardException(x + "," + y + " is outside the boundaries of the board.");
                    }

                    return point;
                }
                catch (OutOfBoardException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }

            }
        }
    }
}
