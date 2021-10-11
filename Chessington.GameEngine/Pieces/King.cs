using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var squares = new List<Square>();
            var locationOfPiece = board.FindPiece(this); 
            
            var direction = currentPlayerColour == Player.White ? -1 : 1;
            var moveOnePositionUp = Square.At(locationOfPiece.Row + direction, locationOfPiece.Col);
            var moveOnePositionDown = Square.At(locationOfPiece.Row - direction, locationOfPiece.Col);
            var moveOnePositionRight = Square.At(locationOfPiece.Row , locationOfPiece.Col + direction);
            var moveOnePositionLeft = Square.At(locationOfPiece.Row , locationOfPiece.Col - direction);
            
            
            if(!board.GetPiece(moveOnePositionUp).Player.Equals(currentPlayerColour)){
                squares.Add(moveOnePositionUp);
            }
            
            if(!board.GetPiece(moveOnePositionDown).Player.Equals(currentPlayerColour)){
                squares.Add(moveOnePositionDown);
            }
            
            if(!board.GetPiece(moveOnePositionRight).Player.Equals(currentPlayerColour)){
                squares.Add(moveOnePositionRight);
            }
            
            if(!board.GetPiece(moveOnePositionLeft).Player.Equals(currentPlayerColour)){
                squares.Add(moveOnePositionLeft);
            }


            return squares;
        }
    }
}