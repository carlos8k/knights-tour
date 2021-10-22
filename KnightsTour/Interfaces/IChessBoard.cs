using KnightsTour.Models;

namespace KnightsTour.Interfaces
{
    public interface IChessBoard
    {
        bool CanMove(ChessPiece piece, int positionX, int positionY);
        ChessBoardSquare GetSquareByPosition(string column, int line);
    }

    public interface IChessBoardSquare
    {
        bool CanMove(ChessPiece piece);
        void Move(ChessPiece piece);
    }
}