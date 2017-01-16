

namespace BattleShip
{
    class Board
    {
        public readonly int Size;

        public Board(int size)
        {
            Size = size;
        }

        //Check whether the point is out of board
        public bool OnBoard(Point point)
        {
            return point.X >= 0 && point.X < Size &&
                   point.Y >= 0 && point.Y < Size;
        }
    }
}

