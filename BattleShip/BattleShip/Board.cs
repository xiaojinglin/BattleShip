using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Board
    {
        public readonly int Size;

        public Board(int size)
        {
            Size = size;
        }

        public bool OnBoard(int x, int y)
        {
            return x >= 0 && x < Size &&
                   y >= 0 && y < Size;
        }
    }
}

