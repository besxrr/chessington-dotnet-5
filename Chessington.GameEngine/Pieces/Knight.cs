using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var squares = new List<Square>();
            
            var locationOfPiece = board.FindPiece(this);

            int[] yCoords = {1, 2, 2, 1, -1, -2, -2, -1};
            int[] xCoords = {2, 1, -1, -2, -2, -1, 1, 2};

            for (int i = 0; i < 8; i++)
            {
                var newRow = locationOfPiece.Row + xCoords[i];
                var newCol = locationOfPiece.Col + yCoords[i];
                var knightMove = new Square(newRow, newCol);
                if (board.OutOfBounds(knightMove) == false)
                {
                    squares.Add(knightMove);
                }
            }
            squares.RemoveAll(sameColourPiece => (board.GetPiece(sameColourPiece) != null && (board.GetPiece(sameColourPiece).Player == Player)));
            return squares;
        }
    }
}