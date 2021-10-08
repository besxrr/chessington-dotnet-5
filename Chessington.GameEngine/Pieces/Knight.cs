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

            var currentPlayerColour = Player.Equals(Player.White) ? Player.White : Player.Black;

            var first = Square.At(locationOfPiece.Row + 2, locationOfPiece.Col +1 );
            var second = Square.At(locationOfPiece.Row + 1, locationOfPiece.Col +2 );
            var third = Square.At(locationOfPiece.Row -1, locationOfPiece.Col +2 );
            var forth = Square.At(locationOfPiece.Row - 2, locationOfPiece.Col +1 );
            var fifth = Square.At(locationOfPiece.Row - 2, locationOfPiece.Col -1 );
            var sixth = Square.At(locationOfPiece.Row -1 , locationOfPiece.Col -2 );
            var seventh = Square.At(locationOfPiece.Row +1 , locationOfPiece.Col -2 );
            var eighth = Square.At(locationOfPiece.Row +2 , locationOfPiece.Col -1 );
            
            // Square.At(locationOfPiece.Row + 2, locationOfPiece.Col + 1 )
            // Square.At(locationOfPiece.Row + 2, locationOfPiece.Col - 1 )
            // Square.At(locationOfPiece.Row - 2, locationOfPiece.Col + 1 )
            // Square.At(locationOfPiece.Row - 2, locationOfPiece.Col - 1 )
            //
            // Square.At(locationOfPiece.Row + 1, locationOfPiece.Col + 2 )
            // Square.At(locationOfPiece.Row + 1, locationOfPiece.Col - 2 )
            // Square.At(locationOfPiece.Row - 1, locationOfPiece.Col + 2 )
            // Square.At(locationOfPiece.Row - 1, locationOfPiece.Col - 2 )
            
            //
            // if (board.GetPiece(moveOnePosition) == null)
            // {
            //     squares.Add(moveOnePosition);
            //
            //     if (!hasMoved && board.GetPiece(moveTwoPosition) == null)
            //     {
            //         squares.Add(moveTwoPosition);
            //     }
            // }
            //
            // if(board.GetPiece(moveDiagonalLeft) != null && !board.GetPiece(moveDiagonalLeft).Player.Equals(currentPlayerColour)){
            //     squares.Add(moveDiagonalLeft);
            // }
            //
            // if(board.GetPiece(moveDiagonalRight) != null && !board.GetPiece(moveDiagonalRight).Player.Equals(currentPlayerColour)){
            //     squares.Add(moveDiagonalRight);
            // }
            //
            return squares;
        }
    }
}