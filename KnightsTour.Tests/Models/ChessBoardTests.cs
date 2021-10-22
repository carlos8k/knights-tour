using KnightsTour.Models;
using System;
using System.Linq;
using Xunit;

namespace KnightsTour.Tests.Models
{
    public class ChessBoardTests
    {
        [Fact]
        public void Board_Has64Squares()
        {
            var board = new ChessBoard();

            Assert.Equal(64, board.Squares.Count);
        }

        [Fact]
        public void Board_AllSquares_AreEmpty()
        {
            var board = new ChessBoard();

            foreach (var square in board.Squares)
            {
                Assert.Null(square.Piece);
                Assert.False(square.HasPiece);
            }
        }

        [Fact]
        public void Board_HasChessBoard_8Lines()
        {
            var board = new ChessBoard();

            for (int line = 1; line <= 8; line++)
                Assert.Equal(8, board.Squares.Count(x => x.Line == line));
        }

        [Fact]
        public void Board_HasChessBoard_8Columns()
        {
            var columns = new[] { "A", "B", "C", "D", "E", "F", "G", "H" };

            var board = new ChessBoard();

            foreach (var column in columns)
                Assert.Equal(8, board.Squares.Count(x => x.Column == column));
        }

        [Fact]
        public void Board_GetSquareByPosition_ValidPosition()
        {
            var board = new ChessBoard();

            var square = board.GetSquareByPosition("A", 1);

            Assert.NotNull(square);
        }

        [Fact]
        public void Board_GetSquareByPosition_InvalidColumn()
        {
            var board = new ChessBoard();

            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => board.GetSquareByPosition("J", 1));

            Assert.Equal("column", exception.ParamName);
            Assert.Equal($"Column must be between 'A'-'H'. Provided 'J' (Parameter 'column')", exception.Message);
        }

        [Fact]
        public void Board_GetSquareByPosition_InvalidLine()
        {
            var board = new ChessBoard();

            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => board.GetSquareByPosition("A", 0));

            Assert.Equal("line", exception.ParamName);
            Assert.Equal($"Line must be between '1'-'8'. Provided '0' (Parameter 'line')", exception.Message);
        }
    }
}