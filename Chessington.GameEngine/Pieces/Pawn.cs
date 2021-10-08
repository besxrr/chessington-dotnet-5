using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {

            var x = 1;
            if (Player == Player.White)
            {
                x = -1;
            }
            
            var locationOfPiece = board.FindPiece(this);
            
            var moves = new List<Square>()
            {
                Square.At(locationOfPiece.Row + x, locationOfPiece.Col)
            };
            return moves;
        }
    }
}