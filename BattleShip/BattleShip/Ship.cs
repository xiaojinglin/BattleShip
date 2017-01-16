
namespace BattleShip
{
    class Ship
    {
        public Point ShipLocation{ get; set; }
 
        //Check whether the ship is hited
        public int isHited(Point point)
        {
           return (this.ShipLocation.X == point.X && this.ShipLocation.Y == point.Y) ? 1 : 2;
        }
    }
}
