using KnightsTour.Interfaces;
using System;

namespace KnightsTour.Models
{
    public class KnightTourGame : IKnightTourGame
    {
        public int Moves { get; set; }
        public bool Finalized { get; set; }
        public ChessBoard Board { get; set; }

        public void NextMove()
        {
            throw new NotImplementedException();
        }

        public void Start(int positionX, int positionY)
        {
            throw new NotImplementedException();
        }
    }
}