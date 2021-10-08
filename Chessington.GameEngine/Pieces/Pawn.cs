using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var squares = new List<Square>();
            
            var locationOfPiece = board.FindPiece(this);
            
            var direction = (Player == Player.White) ? -1 : 1;
            
            var moveOnePosition = Square.At(locationOfPiece.Row + direction, locationOfPiece.Col);
            var moveTwoPosition = Square.At(locationOfPiece.Row + direction * 2, locationOfPiece.Col);
            
            var moveDiagonalRight = Square.At(locationOfPiece.Row + direction, locationOfPiece.Col +1);
            var moveDiagonalLeft = Square.At(locationOfPiece.Row, locationOfPiece.Col - 1);
            
            if (board.GetPiece(moveOnePosition) == null)
            {
                squares.Add(moveOnePosition);

                if (!hasMoved && board.GetPiece(moveTwoPosition) == null)
                {
                    squares.Add(moveTwoPosition);
                }
            }
            
            
            return squares;
        }
    }
}