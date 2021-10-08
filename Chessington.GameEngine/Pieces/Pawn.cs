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
            var locationOfPiece = board.FindPiece(this);
            if (Player == Player.White)
            {
                yield return Square.At(locationOfPiece.Row-1, locationOfPiece.Col);
                if (!hasMoved)
                {
                    yield return Square.At(locationOfPiece.Row-2,locationOfPiece.Col);
                }
            }
                
            if (Player == Player.Black)
            {
                yield return Square.At(locationOfPiece.Row+1, locationOfPiece.Col);
                if (!hasMoved)
                {
                    yield return Square.At(locationOfPiece.Row+2,locationOfPiece.Col);
                }
            }
            
        }
    }
}