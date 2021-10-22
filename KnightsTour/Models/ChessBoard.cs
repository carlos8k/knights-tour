using KnightsTour.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsTour.Models
{
    public class ChessBoard : IChessBoard
    {
        readonly int[] lines = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        readonly string[] columns = new[] { "A", "B", "C", "D", "E", "F", "G", "H" };

        public ChessBoard()
        {
            Squares = new List<ChessBoardSquare>();

            foreach (var line in lines)
            {
                foreach (var column in columns)
                {
                    Squares.Add(new ChessBoardSquare
                    {
                        Line = line,
                        Column = column
                    });
                }
            }
        }

        public List<ChessBoardSquare> Squares { get; set; }

        public bool CanMove(ChessPiece piece, int positionX, int positionY)
        {
            throw new System.NotImplementedException();
        }

        public ChessBoardSquare GetSquareByPosition(string column, int line)
        {
            if (!columns.Contains(column))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(column), $"Column must be between 'A'-'H'. Provided '{column}'");
            }

            if (!lines.Contains(line))
            {
                throw new ArgumentOutOfRangeException(
                    nameof(line), $"Line must be between '1'-'8'. Provided '{line}'");
            }

            return Squares.Single(x => x.Column == column && x.Line == line);
        }
    }

    public class ChessBoardSquare : IChessBoardSquare
    {
        public string Column { get; set; }
        public int Line { get; set; }

        public bool HasPiece { get; set; }

        public ChessPiece Piece { get; set; }

        public bool CanMove(ChessPiece piece)
        {
            throw new System.NotImplementedException();
        }

        public void Move(ChessPiece piece)
        {
            throw new System.NotImplementedException();
        }
    }

    public class KnightTourChessBoardSquare : ChessBoardSquare
    {
        public bool Visited { get; set; }
        public int MovesAvailable { get; set; }
    }

    public class ChessPiece
    {
        public string Sprite { get; set; }

        public ChessPiece(string sprite)
        {
            Sprite = sprite;
        }
    }

    public class Knight : ChessPiece
    {
        public Knight() : base("&#9822;") { }
    }
}