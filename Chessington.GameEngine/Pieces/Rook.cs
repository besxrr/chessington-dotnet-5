using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var squares = new List<Square>();
            var locationOfPiece = board.FindPiece(this);

            for (int i = locationOfPiece.Row; i < ; i++)
            {
                
            }
            
            
            
            
            // for (int i = 0; i < 8; i++)
            // {
            //     if (i != locationOfPiece.Row)
            //     {
            //         squares.Add(Square.At(i,locationOfPiece.Col));
            //     }
            // }
            // for (int i = 0; i < 8; i++)
            // {
            //     if (i != locationOfPiece.Col)
            //     {
            //         squares.Add(Square.At(locationOfPiece.Row,i));
            //     }
            // }
            squares.RemoveAll(sameColourPiece => (board.GetPiece(sameColourPiece) != null && (board.GetPiece(sameColourPiece).Player == Player)));
            return squares;
            // TODO - Add in the for loops iteration to also check if the piece in front of them isn't occupied . If it is break the if statement.
        }
    }
}