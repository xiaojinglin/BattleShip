

namespace BattleShip
{
    class Player
    {
        public Ship setShip { get; set; }

        //Check whether the player's ship is hited
        public int isHited (Point point, Point[] points)
        {
            //Check that players don’t accidentally guess locations that they’ve already guessed
            foreach (Point p in points)
            {
                if(p!=null)
                {
                    if (point.X == p.X && point.Y == p.Y)
                    {
                        return 0;
                    }                   
                }
                
            }
            return this.setShip.isHited(point);
        }
    }
}
