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
            
            squares.RemoveAll(sameColourPiece => (board.GetPiece(sameColourPiece) != null && (board.GetPiece(sameColourPiece).Player == Player)));
            return squares;
        }
    }
}