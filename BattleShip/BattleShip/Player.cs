using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Player
    {
        private Ship _ship = new Ship();

        public void setShipLocation(int x, int y, Board board)
        {
            if (!board.OnBoard(x, y))
            {
                throw new OutOfBoardException(x + "," + y + " is outside the boundaries of the board.");
            }

            _ship.X = x;
            _ship.Y = y;
        }
        
        public bool isHited (int x, int y, Board board)
        {
            if (!board.OnBoard(x, y))
            {
                throw new OutOfBoardException(x + "," + y + " is outside the boundaries of the board.");
            }

            return _ship.isHited(x, y);
        }
    }
}
