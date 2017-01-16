

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
