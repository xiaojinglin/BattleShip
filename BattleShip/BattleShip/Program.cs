using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 5;
            Board board = new Board(size);
                   
            try
            {
                Random random = new Random();
                Player play1 = new Player();
                Player play2 = new Player();

                play1.setShipLocation(random.Next(5), random.Next(5), board);
                play2.setShipLocation(4, 4, board);
                Point[] points = {
                    new Point(1,1),
                    new Point(2,1),
                    new Point(3,3),
                    new Point(4,1),
                    new Point(4,2),
                    new Point(4,3),
                };

                string result = "Game Over!";
                foreach (Point point in points)
                {
                   if (play1.isHited(point.X, point.Y ,board))
                    {
                        result = "You won!";
                        break;
                    }
                   if(play2.isHited(random.Next(5), random.Next(5), board))
                    {
                        result = "You lost!";
                        break;
                    }
                }

                Console.WriteLine(result);
 }

            catch (OutOfBoardException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (BattleShipException)
            {
                Console.WriteLine("Unhandled BattleShipException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }


        }
    }
}
