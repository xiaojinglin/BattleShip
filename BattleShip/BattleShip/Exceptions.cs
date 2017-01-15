using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class BattleShipException : System.Exception
    {
        public BattleShipException()
        {
        }

        public BattleShipException(string message) : base(message)
        {
        }
    }

    class OutOfBoardException : BattleShipException
    {
        public OutOfBoardException()
        {
        }

        public OutOfBoardException(string message) : base(message)
        {
        }
    }
}
