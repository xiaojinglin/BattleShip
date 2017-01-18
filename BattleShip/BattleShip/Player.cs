using System.Collections.Generic;

namespace BattleShip
{
    class Player
    {
        public Ship setShip { get; set; }

        //Check whether the player's ship is hited
        public int isHited (Point point, List<Point> points)
        {
            //Check that players don’t accidentally guess locations that they’ve already guessed
            Point duplicatePoint = points.Find(
                delegate(Point p)
                {
                    return p.X == point.X && p.Y == point.Y;
                });

            return duplicatePoint == null ? this.setShip.isHited(point) : 0;
        }
    }
}
