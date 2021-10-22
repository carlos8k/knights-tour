using KnightsTour.Models;

namespace KnightsTour.Interfaces
{
    public interface IKnightTourGame
    {
        void Start(int positionX, int positionY);
        void NextMove();

        int Moves { get; set; }
        bool Finalized { get; set; }
        ChessBoard Board { get; set; }
    }
}